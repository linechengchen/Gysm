
//cch改
//刷题所有页面改为BANG.JS
$(function () {
    var params1
    if (!params1) params1 = getParseQuery();
    var url1 = '?' + transJsonToQuery(params1);
    $('body').on('tap', '.shuati', function () {
        if (window.location.href.indexOf('/shuati/') != -1 || params1.index == 'shuati') return;
        isLogin("../../shuati/pages/indexPage1_shuati.html", "", url1);
    })
    $('body').on('tap', '.zuoye', function () {
        if (params1.index == 'zuoye') return;
        isLogin("../../zuoye/pages/indexPage1_zuoye.html", "", url1);
    })
    $('body').on('tap', '.xianshu', function () {
        if (params1.index == 'xianshu') return;//!params1.index && 
        isLogin("../../xianshu/pages/indexPage1_xianshu.html", "", url1);
    })
    $('body').on('tap', '.xueba', function () {
        if (params1.index == 'xueba') return;
        isLogin("../../xueba/pages/indexPage1_xueba.html", "", url1);
    })
    $('body').on('tap', '.xueche', function () {
        if (params1.index == 'xueche') return;
        isLogin("../../xueche/pages/indexPage1_xueche.html", "", url1);
    })
    $('body').on('tap', '.daina', function () {
        if (params1.index == 'daina') return;
        isLogin("../../daina/pages/indexPage1_daina.html", "", url1);
    })
    $('body').on('tap', '.pinche', function () {
        if (params1.index == 'pinche') return;
        isLogin("../../pinche/pages/indexPage1_pinche.html", "", url1);
    })
    $('body').on('tap', '.jiangtang', function () {
        if (params1.index == 'jiangtang') return;
        isLogin("../../jiangtang/pages/indexPage1_jiangtang.html", "", url1);
    })
    $('body').on('tap', '.bangfen', function () {
        if (params1.index == 'bangfen') return;
        isLogin("../../bangfen/pages/indexPage1_bangfen.html", "", url1);
    })
    $('body').on('tap', '.ziyuan', function () {
        if (params1.index != 'ziyuan') return;
        isLogin("../../ziyuan/pages/indexPage1_ziyuan.html", "", url1);
    })
    $('body').on('tap', '.jianzhi', function () {
        if (params1.index != 'jianzhi') return;
        isLogin("../../jianzhi/pages/indexPage1_jianzhi.html", "", url1);
    })
});