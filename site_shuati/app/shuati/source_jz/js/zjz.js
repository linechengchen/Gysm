//全部分类上下箭头切换
function change_pic(type) {
	var windowheight = document.documentElement.clientHeight;
		if (type == 1) {
			var imgas = document.getElementById("one1");
			var imgObj = document.getElementById("one1");
			var Flag = (imgObj.getAttribute("src", 2) == "https://dn-qtshe.qbox.me/arrowgrey@3x.png")
			imgObj.src = Flag ? "https://dn-qtshe.qbox.me/arrow-green@3x.png" : "https://dn-qtshe.qbox.me/arrowgrey@3x.png";
			$("#bodys_html").addClass("fixed");
			$(".sort").addClass("absolute");
		} else if (type == 2) {
			var imgas = document.getElementById("two1");
			var imgObj = document.getElementById("two1");
			var Flag = (imgObj.getAttribute("src", 2) == "https://dn-qtshe.qbox.me/arrowgrey@3x.png")
			imgObj.src = Flag ? "https://dn-qtshe.qbox.me/arrow-green@3x.png" : "https://dn-qtshe.qbox.me/arrowgrey@3x.png";
			$("#bodys_html").addClass("fixed");
			$(".sort").addClass("absolute");
		} else if (type == 3) {
			var imgas = document.getElementById("three1");
			var imgObj = document.getElementById("three1");
			var Flag = (imgObj.getAttribute("src", 2) == "https://dn-qtshe.qbox.me/arrowgrey@3x.png")
			imgObj.src = Flag ? "https://dn-qtshe.qbox.me/arrow-green@3x.png" : "https://dn-qtshe.qbox.me/arrowgrey@3x.png";
			$("#bodys_html").addClass("fixed");
			$(".sort").addClass("absolute");
		}
		hideOrShowAn();
	}
		$(document).ready(function() {
			$("#one").click(function() {
				$("#one2").slideToggle();
				$("#one3").slideToggle();
				$("#two2").fadeOut("0");
				$("#three2").fadeOut("0");
				$('#xuanze').slideToggle();
				$("#two1").attr("src", "https://dn-qtshe.qbox.me/arrowgrey@3x.png");
				$("#three1").attr("src", "https://dn-qtshe.qbox.me/arrowgrey@3x.png");
				$("#one").addClass("greens");
				$("#two").removeClass("greens");
				$("#three").removeClass("greens");
				if($("#one1").attr("src") === "https://dn-qtshe.qbox.me/arrowgrey@3x.png"){
					$('.sort ul li').removeClass("greens");
					$("#bodys_html").removeClass("fixed");
					$(".sort").removeClass("absolute");
				}
				hideOrShowAn();
			});
			$("#two").click(function() {
				$("#two2").slideToggle();
				$("#one2").fadeOut("0");
				$("#three2").fadeOut("0");
				$("#one3").fadeOut("0");
				$('#xuanze').hide();
				$("#one1").attr("src", "https://dn-qtshe.qbox.me/arrowgrey@3x.png");
				$("#three1").attr("src", "https://dn-qtshe.qbox.me/arrowgrey@3x.png");
				$("#two").addClass("greens");
				$("#one").removeClass("greens");
				$("#three").removeClass("greens");
				if($("#two1").attr("src") === "https://dn-qtshe.qbox.me/arrowgrey@3x.png"){
					$('.sort ul li').removeClass("greens");
					$("#bodys_html").removeClass("fixed");
					$(".sort").removeClass("absolute");
				}
				hideOrShowAn();
			});
			$("#three").click(function() {
				$("#three2").slideToggle();
				$("#one1").attr("src", "https://dn-qtshe.qbox.me/arrowgrey@3x.png");
				$("#one2").fadeOut("0");
				$("#two2").fadeOut("0");
				$("#one3").fadeOut("0");
				$('#xuanze').hide();
				$("#two1").attr("src", "https://dn-qtshe.qbox.me/arrowgrey@3x.png");
				$("#two").removeClass("greens");
				$("#one").removeClass("greens");
				$("#three").addClass("greens");
				if($("#three1").attr("src") === "https://dn-qtshe.qbox.me/arrowgrey@3x.png"){
					$('.sort ul li').removeClass("greens");
					$("#bodys_html").removeClass("fixed");
					$(".sort").removeClass("absolute");
				}
				hideOrShowAn();
			});
		});

$(".bgh").click(function() {
	$(".bgh").fadeOut("slow");
	$("#one2").fadeOut("slow");
	$("#one3").fadeOut("0");
	$("#one1").attr("src", "https://dn-qtshe.qbox.me/arrowgrey@3x.png");
	$("#two2").fadeOut("slow");
	$("#two1").attr("src", "https://dn-qtshe.qbox.me/arrowgrey@3x.png");
	$("#three2").fadeOut("slow");
	$("#three1").attr("src", "https://dn-qtshe.qbox.me/arrowgrey@3x.png");
});
function isImg(src, fileName) {
	var falg = false;
	if (isEmpty(src) || isEmpty(fileName)) {
		return falg;
	}
	try {
		if (src.split("/")[src.split("/").length - 1] == fileName) {
			falg = true;
		}
		return falg;
	} catch (e) {
		if (src == fileName) {
			falg = true;
		}
		return falg;
	}
}
function hideOrShowAn() {
	var fileName = "arrowgrey@3x.png";
	if (isImg($("#one1").attr("src"), fileName) && isImg($("#two1").attr("src"), fileName) && isImg($("#three1").attr("src"), fileName)) {
		$(".bgh").fadeOut(); //如果元素为显现,则将它隐藏
	} else {
		$(".bgh").fadeIn(); //如果元素为隐藏,则将它显现
	}
}