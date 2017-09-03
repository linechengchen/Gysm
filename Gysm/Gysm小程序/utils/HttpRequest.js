console.clear();
const hostUrl = 'http://api.9agy.com/'
const hostUrlNew = 'http://api.9agy.com/'
const hostUrlThird = 'http://api.9agy.com/'

//本地调试
// const hostUrl = 'http://localhost:50378'
// const hostUrlNew = 'http://localhost:50378'
// const hostUrlThird = 'http://localhost:50378'
//const hostUrl = 'http://wyl510.imwork.net/zhuxuetang'
//const hostUrl = 'http://stbd.javalong.com:8080/zhuxuetang'
var isDebug = true;

function clearAll(str, rep1, rep2) {
  if (rep1)
    str = str.split(rep1).join(rep2);
  return str;
}
//进行json解析
function json2url(postData) {
  var js1 = JSON.stringify(postData);
  js1 = clearAll(js1, ':', '=');
  js1 = clearAll(js1, ',', '&');
  js1 = clearAll(js1, '{', '');
  js1 = clearAll(js1, '}', '');
  js1 = clearAll(js1, '"', '');
  return js1;
}
function request(url, postData, doSuccess, doComplete) {
  //Authorization: Basic QWxhZGRpbjpvcGVuIHNlc2FtZQ==
  //Warning  Warn: 199 Miscellaneous warning

  var url1 = hostUrl + url;
  if (isDebug) {
    if (url1.indexOf('?') == -1)
      url1 += "?neice=1";
    else
      url1 += "&neice=1";
  }
  console.info(url1 + '?' + json2url(postData));
  wx.request({
    url: url1,
    header: {
      "Content-Type": "application/x-www-form-urlencoded"
    },
    data: postData,
    method: 'POST',
    success: function (res) {
      if (res.data.resultValue == 0) {
        if (typeof doSuccess == "function") {
          doSuccess(res.data.resultObject);
        }
      } else if (res.data.resultValue == -1000) {
        wx.showToast({
          title: '请重新登录',
          icon: 'loading',
          duration: 1500
        })
      } else {
        wx.showToast({
          title: res.data.msg,
          icon: 'loading',
          duration: 1500
        })
      }
    },
    fail: function () {
      wx.showToast({
        title: '服务器网络错误',
        icon: 'loading',
        duration: 2000
      })
    },
    complete: function (res) {
      console.log(res)
      typeof doComplete == "function" && doComplete
    }
  });
}

function requestThird(url, postData, doSuccess, doComplete) {

  var url1 = hostUrlThird + url;
  if (isDebug) {
    if (url1.indexOf('?') == -1)
      url1 += "?neice=1";
    else
      url1 += "&neice=1";
  }
  console.info(url1 + '?' + json2url(postData));
  wx.request({
    url: url1,
    header: {
      "Content-Type": "application/x-www-form-urlencoded"
    },
    data: postData,
    method: 'POST',
    success: function (res) {
      if (res.data.resultCode == 200) {
        if (typeof doSuccess == "function") {
          doSuccess(res.data);
        }
      } else if (res.data.resultCode == -1000) {
        wx.showToast({
          title: '请重新登录',
          icon: 'loading',
          duration: 1500
        })
      } else {
        wx.showToast({
          title: res.data.msg,
          icon: 'loading',
          duration: 1500
        })
      }
    },
    fail: function () {
      wx.showToast({
        title: '服务器网络错误',
        icon: 'loading',
        duration: 2000
      })
    },
    complete: function (res) {
      console.log(res)
      typeof doComplete == "function" && doComplete
    }
  });
}

function requestNew(url, postData, doSuccess, doComplete) {

  var url1 = hostUrlNew + url;
  if (isDebug) {
    if (url1.indexOf('?') == -1)
      url1 += "?neice=1";
    else
      url1 += "&neice=1";
  }
  console.info(url1 + '?' + json2url(postData));
  wx.request({
    url: url1,
    header: {
      "Content-Type": "application/x-www-form-urlencoded"
    },
    data: postData,
    method: 'POST',
    success: function (res) {
      if (res.data.resultCode == 200) {
          if (typeof doSuccess == "function") {
            doSuccess(res.data.data);
          }
      } else if (res.data.resultCode == -1000) {
        wx.showToast({
          title: '请重新登录',
          icon: 'loading',
          duration: 1500
        })
      } else {
        wx.showToast({
          title: res.data.msg,
          icon: 'loading',
          duration: 1500
        })
      }
    },
    fail: function () {
      wx.showToast({
        title: '服务器网络错误',
        icon: 'loading',
        duration: 2000
      })
    },
    complete: function (res) {
      console.log(res)
      typeof doComplete == "function" && doComplete
    }
  });
}
module.exports = {
  httpRequest: request,
  httpRequestNew: requestNew,
  httpRequestThird: requestThird,
  hostUrlNew: hostUrlNew,
}
