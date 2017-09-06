$(document).on('click','#J-tj',function(){
    var classid = $('#J-tj').data('cid');    
    //$.page(C.U('User/Classes/lslayer', 'classes_id=' + classid), '860px');
    $.page(C.U('/AutoJsonPages/Xt_note/Xt_note_add.aspx', 'classes_id=' + classid), '860px');
});
$(document).on('click','.note-body .J-top',function(e){
    var btn = $(this),
        tip = btn.data('tips'),
        top = btn.offset().top - $(window).scrollTop(),
        left = btn.offset().left - $(window).scrollLeft(),
        dataId = btn.parents('.notice-item').data('id'),
        cTips = $('.csx-tips'),
        theItem = $('.notice-item[data-id="' + dataId + '"]'),        
        isTop = theItem.data('istop');//是否置顶
    e.stopPropagation();
    //alert(isTop)
    if(!cTips.is(':hidden')){
        cTips.fadeOut(200);
    }else{
        cTips.find('.J-top a').html(isTop == "1" ? '取消置顶' : '置顶');
        cTips.attr('data-id',dataId).css({
            top: top + 40,
            left: left - 20
        }).fadeIn(200);
    }
});
$(document).on('click','.note-body .J-edit',function(){
    var item = $(this).parents('.notice-item'),
        id = item.attr('data-id'),
        classid = $('#J-tj').data('cid');
    //$.page(C.U('User/Classes/lslayer', 'classes_id=' + classid + '&id=' + id),'860px');
    $.page(C.U('/AutoJsonPages/Xt_note/Xt_note_edit.aspx', 'classes_id=' + classid + '&uuid=' + id), '860px');
});
$(document).on('click','.note-body .J-del',function(){
    var item = $(this).parents('.notice-item'),
        id = item.attr('data-id'),
        classid = $('#J-tj').data('cid');
    layer.confirm('确定删除该公告吗？', {
        btn: ['确定','取消']
    }, function () {
        //alert(id)
		$.get(
			//C.U('User/Classes/del_note'),
            C.U('/AutoJsonPages/Xt_note/Xt_note_json.aspx?act=delete'),
			{ 'classes_id': classid, 'uuid': id },//id
			function(result){
				if(result.code == 'Y'){
					$.ui.success('已删除',1000,function(){
                        item.remove();
                    });
				}else{
					$.ui.error(result.info);
					item.fadeOut(200);
				}
        },'json');
    });
});
$(document).on('click','.note-body .J-top',function(){
    var btn = $(this),
        item = $(this).parents('.notice-item'),
        id = item.attr('data-id'),
        isTop = item.attr('data-istop'),
        classid = $('#J-tj').data('cid');
    $.get(
		//C.U('User/Classes/update_note'),
        C.U('/AutoJsonPages/Xt_note/Xt_note_json.aspx?act=update'),
		{'uuid':id,'top':isTop,'classes_id':classid},
		function (e) {
		    //alert(e.code)
			if(e.code == '200'){
				$.ui.success(e.info,600,function(){
					window.location.href = e.url;
				})
			}else{
				$.ui.error(e.info);
			}
		}
	)
});