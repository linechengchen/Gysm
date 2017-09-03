var util = require('../../utils/util.js')
Page({
  data: {
    indexmenu: [],
    imgUrls: []
  },
  onLoad: function () {
    //生命周期函数--监听页面加载
    this.fetchData();
    // var that = this
    // //调用应用实例的方法获取全局数据
    // app.getUserInfo(function(userInfo){
    //   //更新数据
    //   that.setData({
    //     userInfo:userInfo
    //   })
    // })
  },
  fetchData: function () {
    this.setData({
      indexmenu: [
        {
          'icon': './../../images/icon_01.png',
          'text': '苹果Air',
          'url': 'space'
        },
        {
          'icon': './../../images/icon_03.png',
          'text': '苹果pro',
          'url': 'service'
        },
        {
          'icon': './../../images/icon_05.png',
          'text': '苹果mac',
          'url': 'conference'
        },
        {
          'icon': './../../images/icon_07.png',
          'text': '外星人',
          'url': 'resource'
        },
        {
          'icon': './../../images/icon_09.png',
          'text': '苹果macbook',
          'url': 'question'
        },
        {
          'icon': './../../images/icon_11.png',
          'text': '物业服务',
          'url': 'property'
        },
        {
          'icon': './../../images/icon_13.png',
          'text': '入驻申请',
          'url': 'apply'
        }
      ],
      imgUrls: [
        '../../images/banner_02.jpg',
        'http://img06.tooopen.com/images/20160818/tooopen_sy_175866434296.jpg',
        'http://img06.tooopen.com/images/20160818/tooopen_sy_175833047715.jpg'
      ]
    })
  },
});