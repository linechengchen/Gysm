var LocString = String(window.document.location.href); 
function getQueryStr(str) { 
	var rs = new RegExp("(^|)" + str + "=([^&]*)(&|$)", "gi").exec(LocString), tmp; 
	if (tmp = rs) {
	    //alert(tmp[2] + "=====" + str);
		return tmp[2]; 
	} 
	// parameter cannot be found 
	return ""; 
}