<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Xt_note_add.aspx.cs" Inherits="AutoJsonPages_Xt_note_Add" %>
<%@ Import Namespace="AgileFrame.Orm.PersistenceLayer.Model"%><%@ Import Namespace="AgileFrame.Core"%>
<div class="modal-header">
    <button type="button" class="J-m-close close" ><span >&times;</span></button>
    <h4 class="modal-title">添加公告</h4>
</div>
<div class="modal-body note-modal-b">
    <div class="col-xs-12 notice-board">
        <form class="form-horizontal" method="post" action="/AutoJsonPages/Xt_note/Xt_note_json.aspx?act=add" data-ajax="true" data-check="C.savenote">
            <div class="form-group">
                <label class="control-label">公告名称：</label>
                <input class="rele-com-inp" name="Title" placeholder="公告名称" value="<%=result1._Title %>" />
                <input type="hidden" name="Course_id" value="<%=Course_id %>">
                            </div>
            <div class="form-group">
                <label class="control-label">公告简介：</label>
                <textarea name="content" class="rele-com-inp" placeholder="公告简介" value=""><%=result1.Content %></textarea>
            </div>
            <div class="form-group">
                
                <div  >
                    <label class="control-label">选择添加到班级：<%=getTeacher_id() %></label>                
                    <div class="note-clas-list">
                        <%foreach(Xt_course course1 in list1){ %>
                        <label class="control-label">
                            <input type="checkbox" name="classid[]" value="<%=course1.Uuid %>" <%=(course1.Uuid.ToString().ToLower() == Course_id.ToLower())?"checked":"" %> />
                            <span><%=course1.Courser_caption %></span>
                        </label>       
                        <%} %>
                    </div>
                </div>
                <button type="submit" class=" btn pull-right rele-com-btn btn-orange all-trans">确定</button>
            </div>
        </form>
    </div>
</div>
<script type="text/javascript">
    C.savenote = function () {
        var isVali = true,
        noteCont = $('.modal-body.note-modal-b');
        noteTitle = noteCont.find('[name="Title"]'),
        noteTitleVal = noteTitle.val(),
        checkBox = noteCont.find('input[type="checkbox"]:checked'),
        len = checkBox.length;
        if (!noteTitleVal) {
            $.ui.error('公告标题不能为空!');
            noteTitle.focus();
            isVali = false;
            return false;
        }
        if (len == 0) {
            $.ui.error('请选择班级!');
            isVali = false;
            return false;
        }
        return isVali;
    };
    $(document).on('click', '.J-m-close', function () {
        $.page.close();
    });

</script>