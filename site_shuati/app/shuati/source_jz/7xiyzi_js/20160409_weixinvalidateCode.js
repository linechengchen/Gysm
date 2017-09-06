var time;
	var clock = 59;
	var code = 0;
	
	if(!isEmpty(getExpiresTime()) && getExpiresTime() != 0) {
		clock = getExpiresTime();
		$(".fast-code-show").text(clock + "秒");
		clockStatus(1);
		time = setInterval("updateClock()", 1000);
	}
	
	function setExpiresTime(value) {
		var expiresDate= new Date();
		expiresDate.setTime(expiresDate.getTime() + (1 * 60 * 1000));
		$.cookie('imageCode', value, { expires: expiresDate });
	}
	
	function setExpiresTimeValue(value) {
		$.cookie('imageCode', value);
	}
	
	function getExpiresTime() {
		return $.cookie('imageCode');
	}
	function updateClock() {
		if(clock > 0) {
			$(".fast-code-show").text(clock + "秒");
			clock = clock - 1;
			
		} else {
			clock = 59;
			clearInterval(time);
			clockStatus(2);
		}
	};
	
	function clockStatus(i) {
		if(i == 1) {
			$(".fast-code-click").hide();
			$(".fast-code-show").show();
			$(".msgs").removeAttr("onclick");
		} else {
			$(".fast-code-click").show();
			$(".fast-code-show").hide();
//			$(".msgs").Attr("onclick");
 			$('#btn').unbind("click");
//			document.getElementsByClassName('msgs').setAttribute("onclick","Obtain()");
		}
	}