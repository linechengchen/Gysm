var httpRequest = require('../../utils/HttpRequest.js');
var util = require('../../utils/util.js');
var app = getApp();
Page({
    data: {
        result: {},
        teacherList: [],
        pageNum: 1,
        pageSize: 10,
        isLoading: true,
        loadOver: false,

        selectKemu: 1,//zlg
        selectGrade: 0,
        selectCatelog: 0,
        selectDataTime: '',
        date: [],
        _date: [],
        time: [],
        selectDate: 0,
        selectTime: 0,
        _selectDate: 0,
        _selectTime: 0,
        pickerDateState: true,
        audioCtx: {},
        selectPlayItem: -1,
        searchKeys: {},
        kemu: {},
        urlPath: "https://stbd.javalong.com/xb/FileUploader/yunti/",

        //cch
        //用户信息
        userInfo: "",
        grade: 0,
        kemu: 0,
    },
    onLoad: function (options) {//载入函数
        var that = this
        that.setData({
            grade: options.grade,
            kemu: options.kemu,
         
        })
        // userInfo: wx.getStorageSync(app.globalData.storageUserInfo)
        // if (that.data.userInfo == "") {
        //     app.userLogin(function () {
        //         that.setData({
        //             userInfo: wx.getStorageSync(app.globalData.storageUserInfo)
        //         })
        //         that.getTeacherInfo();
        //     });
        // } else {
        //     that.getTeacherInfo();
        // }
        this.init();
        this.getTeacherList();
    },
    onShow: function () {//显示
        var optionsStorage = wx.getStorageSync('options')
        if (optionsStorage && optionsStorage.is_submit) {
            this.setData({
                searchKeys: optionsStorage,
                teacherList: [],
                pageNum: 1,
                loadOver: false,
                isLoading: true
            });
            this.getTeacherList()
            optionsStorage.is_submit = false;
            wx.setStorage({
                key: "options",
                data: optionsStorage
            });
        }
    },
    onReady: function (e) {//
        this.audioCtx = wx.createAudioContext('my_audio')
    },
    onUnload: function (e) {
        wx.removeStorage({
            key: 'options',
            success: function (res) {
                console.log(res.data)
            }
        })
    },
    init: function () {//载入
        var curDate = new Date();
        var date = ["不限"];
        var _date = ["不限"];
        var time = ["不限"];
        const week = ["星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六"];
        for (let i = 0; i < 14; i++) {
            let dataTime = util.getDateStr(curDate, i);
            var d = new Date(dataTime);
            date.push(((d.getMonth() + 1) < 10 ? ('0' + (d.getMonth() + 1)) : (d.getMonth() + 1)) + "月" + (d.getDate() < 10 ? ('0' + d.getDate()) : d.getDate()) + "日(" + week[d.getDay()] + ")");
            _date.push(dataTime);
        }
        for (let i = 0; i < 24; i++) {
            time.push((i < 10 ? "0" + i : i) + ":00");
            time.push((i < 10 ? "0" + i : i) + ":30");
        }
        this.setData({
            date: date,
            _date: _date,
            time: time,
        })
    },
    getTeacherList: function () {
        var that = this
        if (wx.showLoading)
            wx.showLoading({
                title: "正在加载..."
            });
 

        var url = '/chuzu.aspx';
        var postData = {
            user_id: that.data.userInfo.user_id, act: "list", pageNum: that.data.pageNum, pageSize: that.data.pageSize,
            kemu: that.data.selectKemu,
            grade: that.data.selectGrade, time: that.data.selectDate == 0 ? "" : that.data.selectTime == 0 ? that.data._date[that.data.selectDate] : that.data._date[that.data.selectDate] + " " + that.data.time[that.data.selectTime], catelog: that.data.selectCatelog
        };
        if (that.data.searchKeys) {
            Object.keys(that.data.searchKeys).forEach(function (optionItem) {
                if (optionItem == "selectDate");
                else if (optionItem == "selectKemu");
                else if (optionItem == "selectTime");
                else if (optionItem == "catelog");
                else if (optionItem == "grade");
                else if (optionItem == "is_submit");
                else if (optionItem == "keyWord");
                else {
                    postData[optionItem] = that.data.searchKeys[optionItem]
                }
            });
        }
        var doSuccess = function (data) {
            if (data.Xb_timu_student && data.Xb_timu_student.length > 0) {
                var _teacherList = data.Xb_timu_student;
                _teacherList.forEach(function (classItem) {
                    classItem.voiceIcon = "/images/icon-voice.png"
                });
                that.setData({
                    kemu: data.kemu,
                    result: data,
                    teacherList: that.data.teacherList.concat(_teacherList),
                    isLoading: false
                })
            } else {
                that.setData({
                    result: data,
                    isLoading: true,
                    loadOver: true
                })
            }
            if (wx.hideLoading) {
                wx.hideLoading();
            }
        }
        httpRequest.httpRequestNew(url, postData, doSuccess);

    },
    selectKemu: function (e) {
        this.setData({
            selectKemu: e.currentTarget.dataset.index,
            teacherList: [],
            pageNum: 1,
            loadOver: false,
            isLoading: true
        })
        this.getTeacherList()
    },
    selectCatelog: function (e) {
        this.setData({
            selectCatelog: e.currentTarget.dataset.index,
            teacherList: [],
            pageNum: 1,
            loadOver: false,
            isLoading: true
        })
        this.getTeacherList()
    },
    bindKemuPickerChange: function (e) {
        this.setData({
            selectKemu: this.data.result.kemu[e.detail.value].key,
            teacherList: [],
            pageNum: 1,
            loadOver: false,
            isLoading: true
        })
        this.getTeacherList()
    },
    bindGradePickerChange: function (e) {
        this.setData({
            selectGrade: this.data.result.grade[e.detail.value].key,
            teacherList: [],
            pageNum: 1,
            loadOver: false,
            isLoading: true
        })
        this.getTeacherList()
    },
    showPickerDate: function () {
        this.setData({
            pickerDateState: false
        })
    },
    hidePickerDate: function () {
        this.setData({
            pickerDateState: true
        })
    },
    bindPickerChange: function (e) {
        if (e.detail.value[0] == 0)
            this.setData({
                _selectDate: 0,
                _selectTime: 0,
            })
        else
            this.setData({
                _selectDate: e.detail.value[0],
                _selectTime: e.detail.value[1],
            })
    },
    confirmSelect: function () {
        var that = this;
        that.setData({
            pickerDateState: true,
            teacherList: [],
            pageNum: 1,
            loadOver: false,
            isLoading: true
        })
        setTimeout(function () {
            that.setData({
                selectDate: that.data._selectDate,
                selectTime: that.data._selectTime,
            })
            that.getTeacherList()
        }, 900)
    },
    onPullDownRefresh: function () {
        this.setData({
            teacherList: [],
            pageNum: 1,
            loadOver: false,
            isLoading: true
        })
        this.getTeacherList()
        wx.stopPullDownRefresh()
    },
    showTeacherInfo: function (e) {
        wx.navigateTo({
          url: '/pages/detail/detail'
        })
    },
    showSearch: function () {
        wx.navigateTo({
            url: '../searchInfo/searchInfo?selectDate=' + this.data.selectDate + '&selectTime=' + this.data.selectTime
                + '&kemu=' + this.data.selecKemu + '&grade=' + this.data.selectGrade + '&catelog=' + this.data.selectCatelog
        })
    },
    playVoice: function (e) {
        var _teacherList = this.data.teacherList;
        if (e.currentTarget.dataset.index == this.data.selectPlayItem) {
            _teacherList[e.currentTarget.dataset.index].voiceIcon = "/images/icon-voice.png";
            this.setData({
                teacherList: _teacherList,
                selectPlayItem: -1
            })
            this.audioCtx.pause()
        }
        else {
            _teacherList[e.currentTarget.dataset.index].voiceIcon = "/images/icon-voice-play.png";
            if (this.data.selectPlayItem != -1)
                _teacherList[this.data.selectPlayItem].voiceIcon = "/images/icon-voice.png";
            this.setData({
                teacherList: _teacherList,
                selectPlayItem: e.currentTarget.dataset.index
            })
            this.audioCtx.setSrc(e.currentTarget.dataset.voiceSrc);
            this.audioCtx.play();
        }
    },
    voiceStop: function () {
        var _teacherList = this.data.teacherList;
        _teacherList[this.data.selectPlayItem].voiceIcon = "/images/icon-voice.png";
        this.setData({
            teacherList: _teacherList
        })
    },
    onReachBottom: function () {
        this.setData({
            isLoading: true,
            loadOver: false,
            pageNum: this.data.pageNum + 1
        })
        this.getTeacherList()
    },
    subString: function (str1, length1) {
        if (str1 && str1.length > length1)
            return str1.subString(0, length1);
        return str1||'';
    },
    onShareAppMessage: function () {

    }
})