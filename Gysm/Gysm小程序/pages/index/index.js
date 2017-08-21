var util = require('../../utils/util.js')  
Page({  
  data: {  
    slider: [],  
    swiperCurrent: 0  
  },  
  onLoad: function () {  
    var that = this;  
//网络访问，获取轮播图的图片  
    util.getRecommend(function(data){  
      that.setData({  
        slider: data.data.slider  
      })  
    });   
  },  
  //轮播图的切换事件  
  swiperChange: function(e){  
//只要把切换后当前的index传给<swiper>组件的current属性即可  
    this.setData({  
      swiperCurrent: e.detail.current  
    })  
  },  
  //点击指示点切换  
  chuangEvent: function(e){  
    this.setData({  
      swiperCurrent: e.currentTarget.id  
    })  
  }  
})  