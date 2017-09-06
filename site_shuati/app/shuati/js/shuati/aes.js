/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */
/*  AES implementation in JavaScript (c) Chris Veness 2005-2012                                   */
/*   - see https://csrc.nist.gov/publications/PubsFIPS.html#197                                    */
/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */

var Aes = {};  // Aes namespace

/**
 * AES Cipher function: encrypt 'input' state with Rijndael algorithm
 *   applies Nr rounds (10/12/14) using key schedule w for 'add round key' stage
 *
 * @param {Number[]} input 16-byte (128-bit) input state array
 * @param {Number[][]} w   Key schedule as 2D byte-array (Nr+1 x Nb bytes)
 * @returns {Number[]}     Encrypted output state array
 */
Aes.cipher = function (input, w) {    // main Cipher function [§5.1]
    var Nb = 4;               // block size (in words): no of columns in state (fixed at 4 for AES)
    var Nr = w.length / Nb - 1; // no of rounds: 10/12/14 for 128/192/256-bit keys

    var state = [[], [], [], []];  // initialise 4xNb byte-array 'state' with input [§3.4]
    for (var i = 0; i < 4 * Nb; i++) state[i % 4][Math.floor(i / 4)] = input[i];

    state = Aes.addRoundKey(state, w, 0, Nb);

    for (var round = 1; round < Nr; round++) {
        state = Aes.subBytes(state, Nb);
        state = Aes.shiftRows(state, Nb);
        state = Aes.mixColumns(state, Nb);
        state = Aes.addRoundKey(state, w, round, Nb);
    }

    state = Aes.subBytes(state, Nb);
    state = Aes.shiftRows(state, Nb);
    state = Aes.addRoundKey(state, w, Nr, Nb);

    var output = new Array(4 * Nb);  // convert state to 1-d array before returning [§3.4]
    for (var i = 0; i < 4 * Nb; i++) output[i] = state[i % 4][Math.floor(i / 4)];
    return output;
}

/**
 * Perform Key Expansion to generate a Key Schedule
 *
 * @param {Number[]} key Key as 16/24/32-byte array
 * @returns {Number[][]} Expanded key schedule as 2D byte-array (Nr+1 x Nb bytes)
 */
Aes.keyExpansion = function (key) {  // generate Key Schedule (byte-array Nr+1 x Nb) from Key [§5.2]
    var Nb = 4;            // block size (in words): no of columns in state (fixed at 4 for AES)
    var Nk = key.length / 4  // key length (in words): 4/6/8 for 128/192/256-bit keys
    var Nr = Nk + 6;       // no of rounds: 10/12/14 for 128/192/256-bit keys

    var w = new Array(Nb * (Nr + 1));
    var temp = new Array(4);

    for (var i = 0; i < Nk; i++) {
        var r = [key[4 * i], key[4 * i + 1], key[4 * i + 2], key[4 * i + 3]];
        w[i] = r;
    }

    for (var i = Nk; i < (Nb * (Nr + 1)) ; i++) {
        w[i] = new Array(4);
        for (var t = 0; t < 4; t++) temp[t] = w[i - 1][t];
        if (i % Nk == 0) {
            temp = Aes.subWord(Aes.rotWord(temp));
            for (var t = 0; t < 4; t++) temp[t] ^= Aes.rCon[i / Nk][t];
        } else if (Nk > 6 && i % Nk == 4) {
            temp = Aes.subWord(temp);
        }
        for (var t = 0; t < 4; t++) w[i][t] = w[i - Nk][t] ^ temp[t];
    }

    return w;
}

/*
 * ---- remaining routines are private, not called externally ----
 */

Aes.subBytes = function (s, Nb) {    // apply SBox to state S [§5.1.1]
    for (var r = 0; r < 4; r++) {
        for (var c = 0; c < Nb; c++) s[r][c] = Aes.sBox[s[r][c]];
    }
    return s;
}

Aes.shiftRows = function (s, Nb) {    // shift row r of state S left by r bytes [§5.1.2]
    var t = new Array(4);
    for (var r = 1; r < 4; r++) {
        for (var c = 0; c < 4; c++) t[c] = s[r][(c + r) % Nb];  // shift into temp copy
        for (var c = 0; c < 4; c++) s[r][c] = t[c];         // and copy back
    }          // note that this will work for Nb=4,5,6, but not 7,8 (always 4 for AES):
    return s;  // see asmaes.sourceforge.net/rijndael/rijndaelImplementation.pdf
}

Aes.mixColumns = function (s, Nb) {   // combine bytes of each col of state S [§5.1.3]
    for (var c = 0; c < 4; c++) {
        var a = new Array(4);  // 'a' is a copy of the current column from 's'
        var b = new Array(4);  // 'b' is a•{02} in GF(2^8)
        for (var i = 0; i < 4; i++) {
            a[i] = s[i][c];
            b[i] = s[i][c] & 0x80 ? s[i][c] << 1 ^ 0x011b : s[i][c] << 1;

        }
        // a[n] ^ b[n] is a•{03} in GF(2^8)
        s[0][c] = b[0] ^ a[1] ^ b[1] ^ a[2] ^ a[3]; // 2*a0 + 3*a1 + a2 + a3
        s[1][c] = a[0] ^ b[1] ^ a[2] ^ b[2] ^ a[3]; // a0 * 2*a1 + 3*a2 + a3
        s[2][c] = a[0] ^ a[1] ^ b[2] ^ a[3] ^ b[3]; // a0 + a1 + 2*a2 + 3*a3
        s[3][c] = a[0] ^ b[0] ^ a[1] ^ a[2] ^ b[3]; // 3*a0 + a1 + a2 + 2*a3
    }
    return s;
}

Aes.addRoundKey = function (state, w, rnd, Nb) {  // xor Round Key into state S [§5.1.4]
    for (var r = 0; r < 4; r++) {
        for (var c = 0; c < Nb; c++) state[r][c] ^= w[rnd * 4 + c][r];
    }
    return state;
}

Aes.subWord = function (w) {    // apply SBox to 4-byte word w
    for (var i = 0; i < 4; i++) w[i] = Aes.sBox[w[i]];
    return w;
}

Aes.rotWord = function (w) {    // rotate 4-byte word w left by one byte
    var tmp = w[0];
    for (var i = 0; i < 3; i++) w[i] = w[i + 1];
    w[3] = tmp;
    return w;
}

// sBox is pre-computed multiplicative inverse in GF(2^8) used in subBytes and keyExpansion [§5.1.1]
Aes.sBox = [0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76,
             0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0,
             0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15,
             0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75,
             0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84,
             0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf,
             0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8,
             0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2,
             0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73,
             0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb,
             0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79,
             0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08,
             0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a,
             0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e,
             0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf,
             0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16];

// rCon is Round Constant used for the Key Expansion [1st col is 2^(r-1) in GF(2^8)] [§5.2]
Aes.rCon = [[0x00, 0x00, 0x00, 0x00],
             [0x01, 0x00, 0x00, 0x00],
             [0x02, 0x00, 0x00, 0x00],
             [0x04, 0x00, 0x00, 0x00],
             [0x08, 0x00, 0x00, 0x00],
             [0x10, 0x00, 0x00, 0x00],
             [0x20, 0x00, 0x00, 0x00],
             [0x40, 0x00, 0x00, 0x00],
             [0x80, 0x00, 0x00, 0x00],
             [0x1b, 0x00, 0x00, 0x00],
             [0x36, 0x00, 0x00, 0x00]];


/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */
/*  AES Counter-mode implementation in JavaScript (c) Chris Veness 2005-2012                      */
/*   - see https://csrc.nist.gov/publications/nistpubs/800-38a/sp800-38a.pdf                       */
/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */

Aes.Ctr = {};  // Aes.Ctr namespace: a subclass or extension of Aes

/** 
 * Encrypt a text using AES encryption in Counter mode of operation
 *
 * Unicode multi-byte character safe
 *
 * @param {String} plaintext Source text to be encrypted
 * @param {String} password  The password to use to generate a key
 * @param {Number} nBits     Number of bits to be used in the key (128, 192, or 256)
 * @returns {string}         Encrypted text
 */
Aes.Ctr.encrypt = function (plaintext, password, nBits) {
    var blockSize = 16;  // block size fixed at 16 bytes / 128 bits (Nb=4) for AES
    if (!(nBits == 128 || nBits == 192 || nBits == 256)) return '';  // standard allows 128/192/256 bit keys
    plaintext = Utf8.encode(plaintext);
    password = Utf8.encode(password);
    //var t = new Date();  // timer

    // use AES itself to encrypt password to get cipher key (using plain password as source for key 
    // expansion) - gives us well encrypted key (though hashed key might be preferred for prod'n use)
    var nBytes = nBits / 8;  // no bytes in key (16/24/32)
    var pwBytes = new Array(nBytes);
    for (var i = 0; i < nBytes; i++) {  // use 1st 16/24/32 chars of password for key
        pwBytes[i] = isNaN(password.charCodeAt(i)) ? 0 : password.charCodeAt(i);
    }
    var key = Aes.cipher(pwBytes, Aes.keyExpansion(pwBytes));  // gives us 16-byte key
    key = key.concat(key.slice(0, nBytes - 16));  // expand key to 16/24/32 bytes long

    // initialise 1st 8 bytes of counter block with nonce (NIST SP800-38A §B.2): [0-1] = millisec, 
    // [2-3] = random, [4-7] = seconds, together giving full sub-millisec uniqueness up to Feb 2106
    var counterBlock = new Array(blockSize);

    var nonce = (new Date()).getTime();  // timestamp: milliseconds since 1-Jan-1970
    var nonceMs = nonce % 1000;
    var nonceSec = Math.floor(nonce / 1000);
    var nonceRnd = Math.floor(Math.random() * 0xffff);

    for (var i = 0; i < 2; i++) counterBlock[i] = (nonceMs >>> i * 8) & 0xff;
    for (var i = 0; i < 2; i++) counterBlock[i + 2] = (nonceRnd >>> i * 8) & 0xff;
    for (var i = 0; i < 4; i++) counterBlock[i + 4] = (nonceSec >>> i * 8) & 0xff;

    // and convert it to a string to go on the front of the ciphertext
    var ctrTxt = '';
    for (var i = 0; i < 8; i++) ctrTxt += String.fromCharCode(counterBlock[i]);

    // generate key schedule - an expansion of the key into distinct Key Rounds for each round
    var keySchedule = Aes.keyExpansion(key);

    var blockCount = Math.ceil(plaintext.length / blockSize);
    var ciphertxt = new Array(blockCount);  // ciphertext as array of strings

    for (var b = 0; b < blockCount; b++) {
        // set counter (block #) in last 8 bytes of counter block (leaving nonce in 1st 8 bytes)
        // done in two stages for 32-bit ops: using two words allows us to go past 2^32 blocks (68GB)
        for (var c = 0; c < 4; c++) counterBlock[15 - c] = (b >>> c * 8) & 0xff;
        for (var c = 0; c < 4; c++) counterBlock[15 - c - 4] = (b / 0x100000000 >>> c * 8)

        var cipherCntr = Aes.cipher(counterBlock, keySchedule);  // -- encrypt counter block --

        // block size is reduced on final block
        var blockLength = b < blockCount - 1 ? blockSize : (plaintext.length - 1) % blockSize + 1;
        var cipherChar = new Array(blockLength);

        for (var i = 0; i < blockLength; i++) {  // -- xor plaintext with ciphered counter char-by-char --
            cipherChar[i] = cipherCntr[i] ^ plaintext.charCodeAt(b * blockSize + i);
            cipherChar[i] = String.fromCharCode(cipherChar[i]);
        }
        ciphertxt[b] = cipherChar.join('');
    }

    // Array.join is more efficient than repeated string concatenation in IE
    var ciphertext = ctrTxt + ciphertxt.join('');
    ciphertext = Base64.encode(ciphertext);  // encode in base64

    //alert((new Date()) - t);
    return ciphertext;
}

/** 
 * Decrypt a text encrypted by AES in counter mode of operation
 *
 * @param {String} ciphertext Source text to be encrypted
 * @param {String} password   The password to use to generate a key
 * @param {Number} nBits      Number of bits to be used in the key (128, 192, or 256)
 * @returns {String}          Decrypted text
 */
Aes.Ctr.decrypt = function (ciphertext, password, nBits) {
    var blockSize = 16;  // block size fixed at 16 bytes / 128 bits (Nb=4) for AES
    if (!(nBits == 128 || nBits == 192 || nBits == 256)) return '';  // standard allows 128/192/256 bit keys
    ciphertext = Base64.decode(ciphertext);
    password = Utf8.encode(password);
    //var t = new Date();  // timer

    // use AES to encrypt password (mirroring encrypt routine)
    var nBytes = nBits / 8;  // no bytes in key
    var pwBytes = new Array(nBytes);
    for (var i = 0; i < nBytes; i++) {
        pwBytes[i] = isNaN(password.charCodeAt(i)) ? 0 : password.charCodeAt(i);
    }
    var key = Aes.cipher(pwBytes, Aes.keyExpansion(pwBytes));
    key = key.concat(key.slice(0, nBytes - 16));  // expand key to 16/24/32 bytes long

    // recover nonce from 1st 8 bytes of ciphertext
    var counterBlock = new Array(8);
    ctrTxt = ciphertext.slice(0, 8);
    for (var i = 0; i < 8; i++) counterBlock[i] = ctrTxt.charCodeAt(i);

    // generate key schedule
    var keySchedule = Aes.keyExpansion(key);

    // separate ciphertext into blocks (skipping past initial 8 bytes)
    var nBlocks = Math.ceil((ciphertext.length - 8) / blockSize);
    var ct = new Array(nBlocks);
    for (var b = 0; b < nBlocks; b++) ct[b] = ciphertext.slice(8 + b * blockSize, 8 + b * blockSize + blockSize);
    ciphertext = ct;  // ciphertext is now array of block-length strings

    // plaintext will get generated block-by-block into array of block-length strings
    var plaintxt = new Array(ciphertext.length);

    for (var b = 0; b < nBlocks; b++) {
        // set counter (block #) in last 8 bytes of counter block (leaving nonce in 1st 8 bytes)
        for (var c = 0; c < 4; c++) counterBlock[15 - c] = ((b) >>> c * 8) & 0xff;
        for (var c = 0; c < 4; c++) counterBlock[15 - c - 4] = (((b + 1) / 0x100000000 - 1) >>> c * 8) & 0xff;

        var cipherCntr = Aes.cipher(counterBlock, keySchedule);  // encrypt counter block

        var plaintxtByte = new Array(ciphertext[b].length);
        for (var i = 0; i < ciphertext[b].length; i++) {
            // -- xor plaintxt with ciphered counter byte-by-byte --
            plaintxtByte[i] = cipherCntr[i] ^ ciphertext[b].charCodeAt(i);
            plaintxtByte[i] = String.fromCharCode(plaintxtByte[i]);
        }
        plaintxt[b] = plaintxtByte.join('');
    }

    // join array of blocks into single plaintext string
    var plaintext = plaintxt.join('');
    plaintext = Utf8.decode(plaintext);  // decode from UTF8 back to Unicode multi-byte chars

    //alert((new Date()) - t);
    return plaintext;
}


/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */
/*  Base64 class: Base 64 encoding / decoding (c) Chris Veness 2002-2012                          */
/*    note: depends on Utf8 class                                                                 */
/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */

var Base64 = {};  // Base64 namespace

Base64.code = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=";

/**
 * Encode string into Base64, as defined by RFC 4648 [https://tools.ietf.org/html/rfc4648]
 * (instance method extending String object). As per RFC 4648, no newlines are added.
 *
 * @param {String} str The string to be encoded as base-64
 * @param {Boolean} [utf8encode=false] Flag to indicate whether str is Unicode string to be encoded 
 *   to UTF8 before conversion to base64; otherwise string is assumed to be 8-bit characters
 * @returns {String} Base64-encoded string
 */
Base64.encode = function (str, utf8encode) {  // https://tools.ietf.org/html/rfc4648
    utf8encode = (typeof utf8encode == 'undefined') ? false : utf8encode;
    var o1, o2, o3, bits, h1, h2, h3, h4, e = [], pad = '', c, plain, coded;
    var b64 = Base64.code;

    plain = utf8encode ? str.encodeUTF8() : str;

    c = plain.length % 3;  // pad string to length of multiple of 3
    if (c > 0) { while (c++ < 3) { pad += '='; plain += '\0'; } }
    // note: doing padding here saves us doing special-case packing for trailing 1 or 2 chars

    for (c = 0; c < plain.length; c += 3) {  // pack three octets into four hexets
        o1 = plain.charCodeAt(c);
        o2 = plain.charCodeAt(c + 1);
        o3 = plain.charCodeAt(c + 2);

        bits = o1 << 16 | o2 << 8 | o3;

        h1 = bits >> 18 & 0x3f;
        h2 = bits >> 12 & 0x3f;
        h3 = bits >> 6 & 0x3f;
        h4 = bits & 0x3f;

        // use hextets to index into code string
        e[c / 3] = b64.charAt(h1) + b64.charAt(h2) + b64.charAt(h3) + b64.charAt(h4);
    }
    coded = e.join('');  // join() is far faster than repeated string concatenation in IE

    // replace 'A's from padded nulls with '='s
    coded = coded.slice(0, coded.length - pad.length) + pad;

    return coded;
}

/**
 * Decode string from Base64, as defined by RFC 4648 [https://tools.ietf.org/html/rfc4648]
 * (instance method extending String object). As per RFC 4648, newlines are not catered for.
 *
 * @param {String} str The string to be decoded from base-64
 * @param {Boolean} [utf8decode=false] Flag to indicate whether str is Unicode string to be decoded 
 *   from UTF8 after conversion from base64
 * @returns {String} decoded string
 */
Base64.decode = function (str, utf8decode) {
    utf8decode = (typeof utf8decode == 'undefined') ? false : utf8decode;
    var o1, o2, o3, h1, h2, h3, h4, bits, d = [], plain, coded;
    var b64 = Base64.code;

    coded = utf8decode ? str.decodeUTF8() : str;


    for (var c = 0; c < coded.length; c += 4) {  // unpack four hexets into three octets
        h1 = b64.indexOf(coded.charAt(c));
        h2 = b64.indexOf(coded.charAt(c + 1));
        h3 = b64.indexOf(coded.charAt(c + 2));
        h4 = b64.indexOf(coded.charAt(c + 3));

        bits = h1 << 18 | h2 << 12 | h3 << 6 | h4;

        o1 = bits >>> 16 & 0xff;
        o2 = bits >>> 8 & 0xff;
        o3 = bits & 0xff;

        d[c / 4] = String.fromCharCode(o1, o2, o3);
        // check for padding
        if (h4 == 0x40) d[c / 4] = String.fromCharCode(o1, o2);
        if (h3 == 0x40) d[c / 4] = String.fromCharCode(o1);
    }
    plain = d.join('');  // join() is far faster than repeated string concatenation in IE

    return utf8decode ? plain.decodeUTF8() : plain;
}


/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */
/*  Utf8 class: encode / decode between multi-byte Unicode characters and UTF-8 multiple          */
/*              single-byte character encoding (c) Chris Veness 2002-2012                         */
/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */

var Utf8 = {};  // Utf8 namespace

/**
 * Encode multi-byte Unicode string into utf-8 multiple single-byte characters 
 * (BMP / basic multilingual plane only)
 *
 * Chars in range U+0080 - U+07FF are encoded in 2 chars, U+0800 - U+FFFF in 3 chars
 *
 * @param {String} strUni Unicode string to be encoded as UTF-8
 * @returns {String} encoded string
 */
Utf8.encode = function (strUni) {
    // use regular expressions & String.replace callback function for better efficiency 
    // than procedural approaches
    var strUtf = strUni.replace(
        /[\u0080-\u07ff]/g,  // U+0080 - U+07FF => 2 bytes 110yyyyy, 10zzzzzz
        function (c) {
            var cc = c.charCodeAt(0);
            return String.fromCharCode(0xc0 | cc >> 6, 0x80 | cc & 0x3f);
        }
      );
    strUtf = strUtf.replace(
        /[\u0800-\uffff]/g,  // U+0800 - U+FFFF => 3 bytes 1110xxxx, 10yyyyyy, 10zzzzzz
        function (c) {
            var cc = c.charCodeAt(0);
            return String.fromCharCode(0xe0 | cc >> 12, 0x80 | cc >> 6 & 0x3F, 0x80 | cc & 0x3f);
        }
      );
    return strUtf;
}

/**
 * Decode utf-8 encoded string back into multi-byte Unicode characters
 *
 * @param {String} strUtf UTF-8 string to be decoded back to Unicode
 * @returns {String} decoded string
 */
Utf8.decode = function (strUtf) {
    // note: decode 3-byte chars first as decoded 2-byte strings could appear to be 3-byte char!
    var strUni = strUtf.replace(
        /[\u00e0-\u00ef][\u0080-\u00bf][\u0080-\u00bf]/g,  // 3-byte chars
        function (c) {  // (note parentheses for precence)
            var cc = ((c.charCodeAt(0) & 0x0f) << 12) | ((c.charCodeAt(1) & 0x3f) << 6) | (c.charCodeAt(2) & 0x3f);
            return String.fromCharCode(cc);
        }
      );
    strUni = strUni.replace(
        /[\u00c0-\u00df][\u0080-\u00bf]/g,                 // 2-byte chars
        function (c) {  // (note parentheses for precence)
            var cc = (c.charCodeAt(0) & 0x1f) << 6 | c.charCodeAt(1) & 0x3f;
            return String.fromCharCode(cc);
        }
      );
    return strUni;
}

/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */


//该代码片段来自于: https://www.sharejs.com/codes/javascript/7310




function Base64() {

    // private property
    _keyStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=";

    // public method for encoding
    this.encode = function (input) {
        var output = "";
        var chr1, chr2, chr3, enc1, enc2, enc3, enc4;
        var i = 0;
        input = _utf8_encode(input);
        while (i < input.length) {
            chr1 = input.charCodeAt(i++);
            chr2 = input.charCodeAt(i++);
            chr3 = input.charCodeAt(i++);
            enc1 = chr1 >> 2;
            enc2 = ((chr1 & 3) << 4) | (chr2 >> 4);
            enc3 = ((chr2 & 15) << 2) | (chr3 >> 6);
            enc4 = chr3 & 63;
            if (isNaN(chr2)) {
                enc3 = enc4 = 64;
            } else if (isNaN(chr3)) {
                enc4 = 64;
            }
            output = output +
            _keyStr.charAt(enc1) + _keyStr.charAt(enc2) +
            _keyStr.charAt(enc3) + _keyStr.charAt(enc4);
        }
        return output;
    }

    // public method for decoding
    this.decode = function (input) {
        var output = "";
        var chr1, chr2, chr3;
        var enc1, enc2, enc3, enc4;
        var i = 0;
        input = input.replace(/[^A-Za-z0-9\+\/\=]/g, "");
        while (i < input.length) {
            enc1 = _keyStr.indexOf(input.charAt(i++));
            enc2 = _keyStr.indexOf(input.charAt(i++));
            enc3 = _keyStr.indexOf(input.charAt(i++));
            enc4 = _keyStr.indexOf(input.charAt(i++));
            chr1 = (enc1 << 2) | (enc2 >> 4);
            chr2 = ((enc2 & 15) << 4) | (enc3 >> 2);
            chr3 = ((enc3 & 3) << 6) | enc4;
            output = output + String.fromCharCode(chr1);
            if (enc3 != 64) {
                output = output + String.fromCharCode(chr2);
            }
            if (enc4 != 64) {
                output = output + String.fromCharCode(chr3);
            }
        }
        output = _utf8_decode(output);
        return output;
    }

    // private method for UTF-8 encoding
    _utf8_encode = function (string) {
        string = string.replace(/\r\n/g, "\n");
        var utftext = "";
        for (var n = 0; n < string.length; n++) {
            var c = string.charCodeAt(n);
            if (c < 128) {
                utftext += String.fromCharCode(c);
            } else if ((c > 127) && (c < 2048)) {
                utftext += String.fromCharCode((c >> 6) | 192);
                utftext += String.fromCharCode((c & 63) | 128);
            } else {
                utftext += String.fromCharCode((c >> 12) | 224);
                utftext += String.fromCharCode(((c >> 6) & 63) | 128);
                utftext += String.fromCharCode((c & 63) | 128);
            }

        }
        return utftext;
    }

    // private method for UTF-8 decoding
    _utf8_decode = function (utftext) {
        var string = "";
        var i = 0;
        var c = c1 = c2 = 0;
        while (i < utftext.length) {
            c = utftext.charCodeAt(i);
            if (c < 128) {
                string += String.fromCharCode(c);
                i++;
            } else if ((c > 191) && (c < 224)) {
                c2 = utftext.charCodeAt(i + 1);
                string += String.fromCharCode(((c & 31) << 6) | (c2 & 63));
                i += 2;
            } else {
                c2 = utftext.charCodeAt(i + 1);
                c3 = utftext.charCodeAt(i + 2);
                string += String.fromCharCode(((c & 15) << 12) | ((c2 & 63) << 6) | (c3 & 63));
                i += 3;
            }
        }
        return string;
    }
}


/**
 *create by 2012-08-25 pm 17:48
 *@author hexinglun@gmail.com
 *BASE64 Encode and Decode By UTF-8 unicode
 *可以和java的BASE64编码和解码互相转化
 */
(function(){
	var BASE64_MAPPING = [
		'A','B','C','D','E','F','G','H',
		'I','J','K','L','M','N','O','P',
		'Q','R','S','T','U','V','W','X',
		'Y','Z','a','b','c','d','e','f',
		'g','h','i','j','k','l','m','n',
		'o','p','q','r','s','t','u','v',
		'w','x','y','z','0','1','2','3',
		'4','5','6','7','8','9','+','/'
	];

	/**
	 *ascii convert to binary
	 */
	var _toBinary = function(ascii){
		var binary = new Array();
		while(ascii > 0){
			var b = ascii%2;
			ascii = Math.floor(ascii/2);
			binary.push(b);
		}
		/*
		var len = binary.length;
		if(6-len > 0){
			for(var i = 6-len ; i > 0 ; --i){
				binary.push(0);
			}
		}*/
		binary.reverse();
		return binary;
	};

	/**
	 *binary convert to decimal
	 */
	var _toDecimal  = function(binary){
		var dec = 0;
		var p = 0;
		for(var i = binary.length-1 ; i >= 0 ; --i){
			var b = binary[i];
			if(b == 1){
				dec += Math.pow(2 , p);
			}
			++p;
		}
		return dec;
	};

	/**
	 *unicode convert to utf-8
	 */
	var _toUTF8Binary = function(c , binaryArray){
		var mustLen = (8-(c+1)) + ((c-1)*6);
		var fatLen = binaryArray.length;
		var diff = mustLen - fatLen;
		while(--diff >= 0){
			binaryArray.unshift(0);
		}
		var binary = [];
		var _c = c;
		while(--_c >= 0){
			binary.push(1);
		}
		binary.push(0);
		var i = 0 , len = 8 - (c+1);
		for(; i < len ; ++i){
			binary.push(binaryArray[i]);
		}

		for(var j = 0 ; j < c-1 ; ++j){
			binary.push(1);
			binary.push(0);
			var sum = 6;
			while(--sum >= 0){
				binary.push(binaryArray[i++]);
			}
		}
		return binary;
	};

	var __BASE64 = {
			/**
			 *BASE64 Encode
			 */
			encoder:function(str){
				var base64_Index = [];
				var binaryArray = [];
				for(var i = 0 , len = str.length ; i < len ; ++i){
					var unicode = str.charCodeAt(i);
					var _tmpBinary = _toBinary(unicode);
					if(unicode < 0x80){
						var _tmpdiff = 8 - _tmpBinary.length;
						while(--_tmpdiff >= 0){
							_tmpBinary.unshift(0);
						}
						binaryArray = binaryArray.concat(_tmpBinary);
					}else if(unicode >= 0x80 && unicode <= 0x7FF){
						binaryArray = binaryArray.concat(_toUTF8Binary(2 , _tmpBinary));
					}else if(unicode >= 0x800 && unicode <= 0xFFFF){//UTF-8 3byte
						binaryArray = binaryArray.concat(_toUTF8Binary(3 , _tmpBinary));
					}else if(unicode >= 0x10000 && unicode <= 0x1FFFFF){//UTF-8 4byte
						binaryArray = binaryArray.concat(_toUTF8Binary(4 , _tmpBinary));	
					}else if(unicode >= 0x200000 && unicode <= 0x3FFFFFF){//UTF-8 5byte
						binaryArray = binaryArray.concat(_toUTF8Binary(5 , _tmpBinary));
					}else if(unicode >= 4000000 && unicode <= 0x7FFFFFFF){//UTF-8 6byte
						binaryArray = binaryArray.concat(_toUTF8Binary(6 , _tmpBinary));
					}
				}

				var extra_Zero_Count = 0;
				for(var i = 0 , len = binaryArray.length ; i < len ; i+=6){
					var diff = (i+6)-len;
					if(diff == 2){
						extra_Zero_Count = 2;
					}else if(diff == 4){
						extra_Zero_Count = 4;
					}
					//if(extra_Zero_Count > 0){
					//	len += extra_Zero_Count+1;
					//}
					var _tmpExtra_Zero_Count = extra_Zero_Count;
					while(--_tmpExtra_Zero_Count >= 0){
						binaryArray.push(0);
					}
					base64_Index.push(_toDecimal(binaryArray.slice(i , i+6)));
				}

				var base64 = '';
				for(var i = 0 , len = base64_Index.length ; i < len ; ++i){
					base64 += BASE64_MAPPING[base64_Index[i]];
				}

				for(var i = 0 , len = extra_Zero_Count/2 ; i < len ; ++i){
					base64 += '=';
				}
				return base64;
			},
			/**
			 *BASE64  Decode for UTF-8 
			 */
			decoder : function(_base64Str){
				var _len = _base64Str.length;
				var extra_Zero_Count = 0;
				/**
				 *计算在进行BASE64编码的时候，补了几个0
				 */
				if(_base64Str.charAt(_len-1) == '='){
					//alert(_base64Str.charAt(_len-1));
					//alert(_base64Str.charAt(_len-2));
					if(_base64Str.charAt(_len-2) == '='){//两个等号说明补了4个0
						extra_Zero_Count = 4;
						_base64Str = _base64Str.substring(0 , _len-2);
					}else{//一个等号说明补了2个0
						extra_Zero_Count = 2;
						_base64Str = _base64Str.substring(0 , _len - 1);
					}
				}

				var binaryArray = [];
				for(var i = 0 , len = _base64Str.length; i < len ; ++i){
					var c = _base64Str.charAt(i);
					for(var j = 0 , size = BASE64_MAPPING.length ; j < size ; ++j){
						if(c == BASE64_MAPPING[j]){
							var _tmp = _toBinary(j);
							/*不足6位的补0*/
							var _tmpLen = _tmp.length;
							if(6-_tmpLen > 0){
								for(var k = 6-_tmpLen ; k > 0 ; --k){
									_tmp.unshift(0);
								}
							}
							binaryArray = binaryArray.concat(_tmp);
							break;
						}
					}
				}

				if(extra_Zero_Count > 0){
					binaryArray = binaryArray.slice(0 , binaryArray.length - extra_Zero_Count);
				}

				var unicode = [];
				var unicodeBinary = [];
				for(var i = 0 , len = binaryArray.length ; i < len ; ){
					if(binaryArray[i] == 0){
						unicode=unicode.concat(_toDecimal(binaryArray.slice(i,i+8)));
						i += 8;
					}else{
						var sum = 0;
						while(i < len){
							if(binaryArray[i] == 1){
								++sum;
							}else{
								break;
							}
							++i;
						}
						unicodeBinary = unicodeBinary.concat(binaryArray.slice(i+1 , i+8-sum));
						i += 8 - sum;
						while(sum > 1){
							unicodeBinary = unicodeBinary.concat(binaryArray.slice(i+2 , i+8));
							i += 8;
							--sum;
						}
						unicode = unicode.concat(_toDecimal(unicodeBinary));
						unicodeBinary = [];
					}
				}
				return unicode;
			}
	};

	window.BASE64 = __BASE64;
})();

