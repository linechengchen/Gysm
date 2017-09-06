var yaoing=false;
var cishu1 = 0;

var cishuKey = "cishu" + new Date().getDate();
cishu1 = getLocal(cishuKey);
if (cishu1 == undefined || cishu1 == null || cishu1 == '')
    cishu1 = 0;
console.log('已抽次数：' + cishu1);

function test2() {
    setLocal(cishuKey, 0);
    myhref.href = window.location.href;
}

function shuaxin()
{
    myhref.href = location.href+'?time='+((new Date()).getTime());
}

function test1() {
    $('.red-ss').addClass('wobble');
    setTimeout(function () {
        console.log('已抽次数：' + cishu1);
        if (cishu1 < 2) {
            if (cishu1 == 1)
            {
                document.getElementById("span2").innerText = "80.00";
             
                $('.red-tc').css('display', 'block');
                dijian()
            }
            else
               {
            document.getElementById("span2").innerText = "50.00";
            $('.red-tc').css('display', 'block');
            dijian()
            }
          
        }
        else if (cishu1 <3) {
           
            $('.red-tc1').css('display', 'block');
            dijian()
         
        }
        else {
        
           
            $('.red-tc2').css('display', 'block');
            dijian()
           
        }

    }, 1500);
}

var dijian= function()
{
    cishu1++;
    setLocal(cishuKey, cishu1)
}

$(document).ready(function () {
 
    if (window.location.href.indexOf("localhost") != -1)
    {
        document.getElementById("ceshi").style.display ="block";
    }
    if (cishu1 > 0) {
        if (cishu1 == 1)
            {
        console.log("次数"+cishu1)
        $('.youhuijuan1').css('display', 'block');
        }
        else if (cishu1 => 2)
        {
            $('.youhuijuan1').css('display', 'block');
            $('.youhuijuan2').css('display', 'block');

        }
    }
    console.log("进入ready");
    if ((3 - cishu1) < 0)
        document.getElementById("span1").innerText = '0';
    else
        document.getElementById("span1").innerText = ''+(3 - cishu1);
    //if (getLocal("cishu") == null) {
    //    var int1 = setLocal("cishu", 3);
    //    if (int1 > 0)
    //        cishu1 = 3;
    //} else {
    //    cishu1 = getLocal("cishu");
    //}
   
    if (window.DeviceMotionEvent) {
       
        var mainzhi = 0;
        var speed = 30;
        var audio = document.getElementById("shakemusic");
     
       
        var openAudio = document.getElementById("openmusic");
        var x = t = z = lastX = lastY = lastZ = 0;
        window.addEventListener('devicemotion',
			function () {
			    var acceleration = event.accelerationIncludingGravity;
			    x = acceleration.x;
			    y = acceleration.y;
			    if (Math.abs(x - lastX) > speed || Math.abs(y - lastY) > speed) {
			        
			        audio.play();
			        if(yaoing==false)
			        {
			            yaoing=true;
			        $('.red-ss').addClass('wobble')
			        setTimeout(function () {
			            audio.pause();
			            openAudio.play();
			            if (cishu1 < 2) {
			                if (cishu1 == 1) {
			                    document.getElementById("span2").innerText = "80.00";

			                    $('.red-tc').css('display', 'block');
			                    dijian()
			                }
			                else {
			                    document.getElementById("span2").innerText = "50.00";
			                    $('.red-tc').css('display', 'block');
			                    dijian()
			                }

			            }
			            else if (cishu1 < 3) {




			                $('.red-tc2').css('display', 'block');
			                dijian()

			            }
			            else {


			                $('.red-tc2').css('display', 'block');
			                dijian()

			            }

			        },1500 ); //1500
			        } 
			    };
			    lastX = x;
			    lastY = y;
			}, false);
    };
  
   
    yaoing=false;
    //$()
});

