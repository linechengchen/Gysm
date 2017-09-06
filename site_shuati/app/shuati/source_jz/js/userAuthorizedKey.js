
saveUserAuthorizedKey();

function saveUserAuthorizedKey() {

	var param = searchParam(window.location.search);

	if(!isEmpty(param.authorizedKey) && isEmpty(window.sessionStorage.authorizedKey)) {

		var data = {};
		data.authorizedKey = param.authorizedKey;
		data.uuid = param.uid;
		
		data.appKey = "QTSHE_WECHAT";
		data.version = '4.0.0';
		$.ajax({
		      type: "post",
		      url: fixUrlJson + "/thirdParty/access",
		      dataType:"JSON",
		      data:data,
		      success:function(data) {
		    	  console.log(data);
		      },
		      error:function() {
		      }
		});
	
		window.sessionStorage.authorizedKey = param.authorizedKey;
		window.sessionStorage.uid = param.uid;
	}

	if(window.sessionStorage.authorizedKey == 'f32b54f6ba3f4f8e9d99c543e56dbacb') {
		$("title").text('我要去兼职');
	} else {
	    $("title").text('爱帮先生，记录你的每一次成长');
	}
}

function getUserAuthorizedKey() {
	var param = window.sessionStorage;
	var p = {};
	p.authorizedKey = param.authorizedKey;
	p.uid = param.uid;
	return p;
}