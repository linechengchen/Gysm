// 获取用户信息
// function getAllMyInfo() {
//     var ajax = $.ajax({ dataType: "json",
//         url: "https://121.199.30.122:12001/user/userInfo/" +
//         type: "GET",
//         cache: false
//     });
//     return ajax;
// }

// 获取所有
function getAllMyAddress() {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlUser + "/user/consignees.aspx?user_id=" + cookieObj.user_id,
        type: "GET",
    });
    return ajax;
}
// 获得一个地址
function getOneAddress(id) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlUser + "/user/consignee.aspx?id=" + id,
        type: "GET",
    });
    return ajax;
}
// 删除一个地址
function deleteOneAddress(id,user_id) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlUser + "/user/delConsignee.aspx",
        beforeSend: function(request) {
            request.setRequestHeader("content-type","application/json");
        },
        data: JSON.stringify({"user_consignee_id": id,"user_id": user_id}),
        type: "POST",// type: "PUT",
    });
    return ajax;
}
// 获取学校
function getSchoolList(city_id) {
    if (!city_id) {
        city_id = currentCityId;
    }
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/schools.aspx?city_id=" + city_id,
        type: "GET",
    });
    return ajax;
}
//获取宿舍
function getDormList(id) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/schools.aspx?id=" + id + "&action=dorms",
        type: "GET",
    });
    return ajax;
}
// 新增地址
function addAddress(data) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlUser + "/user/consignee.aspx",
        type: "POST",
        beforeSend: function(request) {
            request.setRequestHeader("content-type","application/json");
        },
        data: JSON.stringify(data),
    });
    return ajax;
}
// 修改地址
function editAddress(data) {
  var data1 =  {
                "campus": data.campus,
                "campus_id": data.campus_id,
                "consignee_name": data.consignee_name,
                "consignee_phone": data.consignee_phone,
                "consignee_student_no": data.consignee_student_no,
                "dorm": data.dorm,
                "is_default": data.is_default,
                "school": data.school,
                "school_id": data.school_id,
                "user_consignee_id": data.user_consignee_id,
                "user_id": data.user_id
            }
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlUser + "/user/consignee.aspx",
        type: "POST",// type: "POST",// type: "PUT",
        beforeSend: function(request) {
            request.setRequestHeader("content-type","application/json");
        },
        data: JSON.stringify(data1),
    });
    return ajax;
}
//修改默认地址
function defaultAddress(id,user_id) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlUser + "/user/defaultConsignee.aspx",
        type: "POST",// type: "PUT",
        beforeSend: function(request) {
            request.setRequestHeader("content-type","application/json");
        },
        data: JSON.stringify({"user_consignee_id": id,"user_id": user_id}),
    });
    return ajax;
}
// 修改性别
function editSex(sex,user_id) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlUser + "/user/userInfo.aspx",
        beforeSend: function(request) {
            request.setRequestHeader("content-type","application/json");
        },
        data: JSON.stringify({"user_id": user_id, "gender": sex }),
        type: "POST",// type: "PUT",
    });
    return ajax;
}
// 修改用户名
function editUsername(name,user_id) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlUser + "/user/userInfo.aspx",
        beforeSend: function(request) {
            request.setRequestHeader("content-type","application/json");
        },
        data: JSON.stringify({ "user_id": user_id, "nick_name": name }),
        type: "POST",// type: "PUT",
    });
    return ajax;
}
// 修改手机号
function editPhoneNum(uid, phone_number, verifyCode) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlUser + "/user/change_phone_number.aspx",
        beforeSend: function(request) {
            request.setRequestHeader("content-type","application/json");
        },
        data: JSON.stringify({ "user_id": uid, "phone_number": phone_number, "vcode": verifyCode }),
        type: "POST",
    });
    return ajax;
}
// 浏览历史
function getHistory(page, pageSize) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/histories.aspx",
        type: "POST",
        data: { "page": page, "pageSize": pageSize },
    });
    return ajax;
}
// 订单列表
function getOrderList(page, status) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/orders/list.aspx",
        type: "POST",
        data: { "page": page, "orderStatus": status },
    });
    return ajax;
}
// 获取零钱和积分
function getScore() {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/user/profiles/infos.aspx",
        cache: false
    });
    return ajax;
}
// 积分兑换零钱
function scoreExchange(score) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/user/profiles/scores/exchange.aspx",
        type: "POST",
        data: { "score": score },
    });
    return ajax;
}
//积分记录列表
function scoreList(page) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/user/profiles/scores/records.aspx?id=" + page,
        type: "GET",
    });
    return ajax;
}
// 零钱记录列表
function moneyRecordList(page) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/user/profiles/moneys/records.aspx?id=" + page,
        type: "GET",
    });
    return ajax;
}
// 零钱记录详细
function moneyRecordDetail(id) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/user/profiles/moneys/records/jump.aspx?id=" + id,
        type: "GET",
    });
    return ajax;
}
//零钱提现
function moneyWithdraw(money) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/user/profiles/money/apply.aspx",
        type: "POST",
        data:{
            "money": money
        }
    });
    return ajax;
}
// 书本详情
function bookDetail(id) {
    cookieObj.city_id = cookieObj.city_id? cookieObj.city_id : 1;
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/books12.aspx?cityinfo=" + cookieObj.city_id + "&id=" + id,
        type: "GET",
    });
    return ajax;
}
// 购物车列表
function cartList() {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/shopping_carts.aspx?",
        type: "POST",
        data: { "page": "1", "pageSize": "1000" },
    });
    return ajax;
}
// 增加到购物车
function addToCart(id) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/shopping_cart.aspx?",
        type: "POST",
        data: { "relationId": id, "type": "0", "num": "1", "featureId": "0", "city_id": currentCityId },
    });
    return ajax;
}
// 删除到购物车
function deleteFromCart(id) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/shopping_carts.aspx?id=" + id,
        type: "DELETE",
    });
    return ajax;
}
// 生成订单
function createOrder(ids, num, type) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/orders.aspx?",
        type: "POST",
        data: { "ids": ids, "type": type, "num": num, "featureId": '0', "city_id": currentCityId },
    });
    return ajax;
}
// 确认订单
function orderConfirm(tradeNo) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/orders/confirm.aspx?tradeNo=" + tradeNo + "&currentCityId=" + currentCityId,
        type: "GET",
    });
    return ajax;
}
// 获取订单详情
function orderDetail(tradeNo) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/orders.aspx?tradeNo=" + tradeNo,
        type: "GET",
    });
    return ajax;
}
// 微信支付
function wechatPay(tradeNo, change, couponId, couponPrice) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/trade/wxPayParams.aspx",
        type: "POST",
        data: { "tradeNo": tradeNo, "payType": "0", "change": change, "reduction": 0, "couponId": couponId, "couponPrice": couponPrice },
    });
    return ajax;
}
// 修改留言
function changeMessage(tradeNo, message) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/orders/message.aspx?tradeNo=" + tradeNo,
        type: "POST",// type: "PUT",
        data: { "message": message },
    });
    return ajax;
}
// 修改订单地址
function editOrderPlace(tradeNo, aid) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/orders/address.aspx?tradeNo=" + tradeNo + "&aid=" + aid,
        type: "POST",// type: "PUT",
    });
    return ajax;
}
// 取消订单
function cancelOrder(tradeNo) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/orders/close.aspx?tradeNo=" + tradeNo,
        type: "POST",// type: "PUT",
    });
    return ajax;
}
//查询物流信息
function expressDetail(tradeNo, company, isYun, expressNo) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/orders/express.aspx?tradeNo=" + tradeNo,
        type: "POST",
        data: { "company": company, "isYunExpress": isYun, "expressNumber": expressNo },
    });
    return ajax;
}
// 申请退款
function applyRefund(tradeNo) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/orders.aspx?tradeNo=" + tradeNo + "&action=cancel",
        type: "POST",// type: "PUT",
    });
    return ajax;
}
// 零钱支付
function changePay(tradeNo, change, couponId, couponPrice) {
    var ajax = $.ajax({ dataType: "json",
        url: baseUrlJson + "/changePay/success.aspx",
        type: "POST",
        data: { "change": change, "tradeNo": tradeNo , "couponId": couponId, "couponPrice": couponPrice,"reduction": 0}
    });
    return ajax;
}
// 捐书列表
function donateList(page) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/books/collections/records.aspx?page=" + page,
        beforeSend: function (request) {
            request.setRequestHeader("version", "2.0");
        },
        type: "GET",
    });
    return ajax;
}
//提交捐书
function donateBook(data) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/books/collections/apply.aspx",
        beforeSend: function (request) {
            request.setRequestHeader("version", "2.0");
            request.setRequestHeader("token", cookieObj.Token);
        },
        type: "POST",
        data: JSON.stringify(data)
    });
    return ajax;
}
// 捐书详情
function donateBookDetail(id) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/books/collections/records.aspx?id=" + id,
        beforeSend: function (request) {
            request.setRequestHeader("version", "2.0");
            request.setRequestHeader("token", cookieObj.Token);
        },
        type: "GET",
    });
    return ajax;
}
// 取消预约
function cancelDonate(id) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/books/collections.aspx?id=" + id + "&action=cancel",
        beforeSend: function (request) {
            request.setRequestHeader("version", "2.0");
        },
        type: "POST",
    });
    return ajax;
}
// 捐书总数
function DonateTotalNum() {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/books/collections/contribution.aspx",
        beforeSend: function (request) {
            request.setRequestHeader("version", "2.0");
        },
        type: "GET",
    });
    return ajax;
}