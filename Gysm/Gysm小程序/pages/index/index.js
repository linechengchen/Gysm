//index.js
//获取应用实例
var app = getApp()
Page({
  data: {
    motto: 'Hello World',
    userInfo: {},
    banner:"https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1503183489819&di=0430d7dfedb52affc01bec7bdd112637&imgtype=0&src=http%3A%2F%2Fpic.58pic.com%2F58pic%2F13%2F41%2F52%2F83n58PICSeV_1024.jpg",
  },
  //事件处理函数
  bindViewTap: function() {
    wx.navigateTo({
      url: '../logs/logs'
    })
  },
  onLoad: function () {
    console.log('onLoad')
    var that = this
    //调用应用实例的方法获取全局数据
    app.getUserInfo(function(userInfo){
      //更新数据
      that.setData({
        userInfo:userInfo
      })
    })
  }
})
