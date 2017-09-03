function formatTime(date) {
  var year = date.getFullYear()
  var month = date.getMonth() + 1
  var day = date.getDate()

  var hour = date.getHours()
  var minute = date.getMinutes()
  var second = date.getSeconds()


  return [year, month, day].map(formatNumber).join('/') + ' ' + [hour, minute, second].map(formatNumber).join(':')
}
function formatDate(date) {
  var year = date.getFullYear()
  var month = date.getMonth() + 1
  var day = date.getDate()
  return [year, month, day].map(formatNumber).join('-')
}
function formatNumber(n) {
  n = n.toString()
  return n[1] ? n : '0' + n
}
function getDateStr(Datekey, AddDayCount) {
  var d = new Date(Datekey);
  d.setDate(d.getDate() + AddDayCount);//获取AddDayCount天后的日期
  var s = d.getFullYear() + "-" + ((d.getMonth() + 1) < 10 ? ('0' + (d.getMonth() + 1)) : (d.getMonth() + 1)) + "-" + (d.getDate() < 10 ? ('0' + d.getDate()) : d.getDate());
  return s;
}

function newGUID() {
  var guid = new GUID();
  return guid.newGUID();
}
function GUID() {
  this.date = new Date();
  if (typeof this.newGUID != 'function') {
    GUID.prototype.newGUID = function () {
      this.date = new Date();
      var guidStr = '',
        sexadecimalDate = this.hexadecimal(this.getGUIDDate(), 16),
        sexadecimalTime = this.hexadecimal(this.getGUIDTime(), 16);
      for (var i = 0; i < 9; i++) {
        guidStr += Math.floor(Math.random() * 16).toString(16);
      }
      guidStr += sexadecimalDate;
      guidStr += sexadecimalTime;
      while (guidStr.length < 32) {
        guidStr += Math.floor(Math.random() * 16).toString(16);
      }
      return this.formatGUID(guidStr);
    }
    GUID.prototype.getGUIDDate = function () {
      return this.date.getFullYear() + this.addZero(this.date.getMonth() + 1) + this.addZero(this.date.getDay());
    }
    GUID.prototype.getGUIDTime = function () {
      return this.addZero(this.date.getHours()) + this.addZero(this.date.getMinutes()) + this.addZero(this.date.getSeconds()) + this.addZero(parseInt(this.date.getMilliseconds() / 10));
    }
    GUID.prototype.addZero = function (num) {
      if (Number(num).toString() != 'NaN' && num >= 0 && num < 10) {
        return '0' + Math.floor(num);
      } else {
        return num.toString();
      }
    }
    GUID.prototype.hexadecimal = function (num, x, y) {
      if (y != undefined) {
        return parseInt(num.toString(), y).toString(x);
      } else {
        return parseInt(num.toString()).toString(x);
      }
    }
    GUID.prototype.formatGUID = function (guidStr) {
      var str1 = guidStr.slice(0, 8) + '-',
        str2 = guidStr.slice(8, 12) + '-',
        str3 = guidStr.slice(12, 16) + '-',
        str4 = guidStr.slice(16, 20) + '-',
        str5 = guidStr.slice(20);
      return str1 + str2 + str3 + str4 + str5;
    }
  }
}
module.exports = {
  formatTime: formatTime,
  formatDate: formatDate,
  newGUID: newGUID,
  getDateStr: getDateStr,
  alert: alert,
  setStorage: setStorage,
  getStorage: getStorage,
}

//zlg常用函数
function alert(msg) {
  wx.showToast({
    title: msg,
    icon: 'success',
    duration: 2000
  })
}
function setStorage(key1, data1) {
  wx.setStorage({ key: key1, data: data1 });
}
function getStorage(selectGrade, key_name) {
  if (wx.getStorageSync(key_name)) {
    selectGrade = wx.getStorageSync(key_name)
  }
}
