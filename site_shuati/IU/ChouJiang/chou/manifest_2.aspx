{
    "@platforms": ["android", "iPhone", "iPad"],
    "id": "H5CACA300",/*应用的标识，创建应用时自动生成，勿手动修改*/
    "name": "chou",/*应用名称，程序桌面图标名称*/
    "version": {
        "name": "1.0",/*应用版本名称*/
        "code": ""
    },
    "description": "",/*应用描述信息*/
    "icons": {
        "72": "icon.png"
    },
    "launch_path": "index.html",/*应用的入口页面，默认为根目录下的index.html；支持网络地址，必须以https://或https://开头*/
    "developer": {
        "name": "",/*开发者名称*/
        "email": "",/*开发者邮箱地址*/
        "url": ""/*开发者个人主页地址*/
    },
    "permissions": {
        "Accelerometer": {
            "description": "访问加速度感应器"
        },
        "Audio": {
            "description": "访问麦克风"
        },
        "Messaging":{
        	"description": "短彩邮件插件"
        },
        "Cache": {
            "description": "管理应用缓存"
        },
        "Camera": {
            "description": "访问摄像头"
        },
        "Console": {
            "description": "跟踪调试输出日志"
        },
        "Contacts": {
            "description": "访问系统联系人信息"
        },
        "Device": {
            "description": "访问设备信息"
        },
        "Downloader": {
            "description": "文件下载管理"
        },
        "Events": {
            "description": "应用扩展事件"
        },
        "File": {
            "description": "访问本地文件系统"
        },
        "Gallery": {
            "description": "访问系统相册"
        },
        "Geolocation": {
            "description": "访问位置信息"
        },
        "Invocation": {
            "description": "使用Native.js能力"
        },
        "Orientation": {
            "description": "访问方向感应器"
        },
        "Proximity": {
            "description": "访问距离感应器"
        },
        "Storage": {
            "description": "管理应用本地数据"
        },
        
        "Uploader": {
            "description": "管理文件上传任务"
        },
        "Runtime": {
            "description": "访问运行期环境"
        },
        "XMLHttpRequest": {
            "description": "跨域网络访问"
        },
        "Zip": {
            "description": "文件压缩与解压缩"
        },
        "Barcode": {
            "description": "管理二维码扫描插件"
        },
        "Maps": {
            "description": "管理地图插件"
        },
        "Speech": {
            "description": "管理语音识别插件"
        },
        "Webview":{
        	"description": "窗口管理"
        },
        "NativeUI":{
        	"description": "原生UI控件"
        },
        "Navigator":{
        	"description": "浏览器信息"
        },
        "NativeObj":{
        	"description": "原生对象"
        }
    },
    "plus": {
        "splashscreen": {
            "autoclose": true,/*是否自动关闭程序启动界面，true表示应用加载应用入口页面后自动关闭；false则需调plus.navigator.closeSplashscreen()关闭*/
            "waiting": true/*是否在程序启动界面显示等待雪花，true表示显示，false表示不显示。*/
        },
        "popGesture": "close",/*设置应用默认侧滑返回关闭Webview窗口，"none"为无侧滑返回功能，"hide"为侧滑隐藏Webview窗口。参考https://ask.dcloud.net.cn/article/102*/
        "runmode": "normal",/*应用的首次启动运行模式，可取liberate或normal，liberate模式在第一次启动时将解压应用资源（Android平台File API才可正常访问_www目录）*/
        "signature": "Sk9JTiBVUyBtYWlsdG86aHIyMDEzQGRjbG91ZC5pbw==",/*可选，保留给应用签名，暂不使用*/
        "distribute": {
            "apple": {
                "appid": "",/*iOS应用标识，苹果开发网站申请的appid，如io.dcloud.HelloH5*/
                "mobileprovision": "",/*iOS应用打包配置文件*/
                "password": "",/*iOS应用打包个人证书导入密码*/
                "p12": "",/*iOS应用打包个人证书，打包配置文件关联的个人证书*/
                "devices": "universal",/*iOS应用支持的设备类型，可取值iphone/ipad/universal*/
                "frameworks":[
                ]/*调用Native.js调用原生Objective-c API需要引用的FrameWork，如需调用GameCenter，则添加"GameKit.framework"*/
            },
            "google": {
                "packagename": "",/*Android应用包名，如io.dcloud.HelloH5*/
                "keystore": "",/*Android应用打包使用的密钥库文件*/
                "password": "",/*Android应用打包使用密钥库中证书的密码*/
                "aliasname": "",/*Android应用打包使用密钥库中证书的别名*/
               "permissions": ["<uses-permission android:name=\"android.permission.CHANGE_NETWORK_STATE\"/>","<uses-permission android:name=\"android.permission.MOUNT_UNMOUNT_FILESYSTEMS\"/>","<uses-permission android:name=\"android.permission.READ_CONTACTS\"/>","<uses-permission android:name=\"android.permission.VIBRATE\"/>","<uses-permission android:name=\"android.permission.READ_LOGS\"/>","<uses-permission android:name=\"android.permission.ACCESS_WIFI_STATE\"/>","<uses-feature android:name=\"android.hardware.camera.autofocus\"/>","<uses-permission android:name=\"android.permission.WRITE_CONTACTS\"/>","<uses-permission android:name=\"android.permission.ACCESS_NETWORK_STATE\"/>","<uses-permission android:name=\"android.permission.CAMERA\"/>","<uses-permission android:name=\"android.permission.RECORD_AUDIO\"/>","<uses-permission android:name=\"android.permission.GET_ACCOUNTS\"/>","<uses-permission android:name=\"android.permission.MODIFY_AUDIO_SETTINGS\"/>","<uses-permission android:name=\"android.permission.READ_PHONE_STATE\"/>","<uses-permission android:name=\"android.permission.CHANGE_WIFI_STATE\"/>","<uses-permission android:name=\"android.permission.WAKE_LOCK\"/>","<uses-permission android:name=\"android.permission.CALL_PHONE\"/>","<uses-permission android:name=\"android.permission.FLASHLIGHT\"/>","<uses-permission android:name=\"android.permission.ACCESS_COARSE_LOCATION\"/>","<uses-feature android:name=\"android.hardware.camera\"/>","<uses-permission android:name=\"android.permission.ACCESS_FINE_LOCATION\"/>","<uses-permission android:name=\"android.permission.WRITE_SETTINGS\"/>"]
				/*使用Native.js调用原生安卓API需要使用到的系统权限*/
            },
            "orientation": [
                "portrait-primary"
            ],/*应用支持的方向，portrait-primary：竖屏正方向；portrait-secondary：竖屏反方向；landscape-primary：横屏正方向；landscape-secondary：横屏反方向*/
            "icons": {
                "ios": {
                    "prerendered": true, /*应用图标是否已经高亮处理，在iOS6及以下设备上有效*/
                    "auto": "", /*应用图标，分辨率：512x512，用于自动生成各种尺寸程序图标*/
                    "iphone": {
                        "normal": "", /*iPhone3/3GS程序图标，分辨率：57x57*/
                        "retina": "", /*iPhone4程序图标，分辨率：114x114*/
                        "retina7": "", /*iPhone4S/5/6程序图标，分辨率：120x120*/
			"retina8": "", /*iPhone6 Plus程序图标，分辨率：180x180*/
                        "spotlight-normal": "", /*iPhone3/3GS Spotlight搜索程序图标，分辨率：29x29*/
                        "spotlight-retina": "", /*iPhone4 Spotlight搜索程序图标，分辨率：58x58*/
                        "spotlight-retina7": "", /*iPhone4S/5/6 Spotlight搜索程序图标，分辨率：80x80*/
                        "settings-normal": "", /*iPhone4设置页面程序图标，分辨率：29x29*/
                        "settings-retina": "", /*iPhone4S/5/6设置页面程序图标，分辨率：58x58*/
			"settings-retina8": "" /*iPhone6Plus设置页面程序图标，分辨率：87x87*/
                    },
                    "ipad": {
                        "normal": "", /*iPad普通屏幕程序图标，分辨率：72x72*/
                        "retina": "", /*iPad高分屏程序图标，分辨率：144x144*/
                        "normal7": "", /*iPad iOS7程序图标，分辨率：76x76*/
                        "retina7": "", /*iPad iOS7高分屏程序图标，分辨率：152x152*/
                        "spotlight-normal": "", /*iPad Spotlight搜索程序图标，分辨率：50x50*/
                        "spotlight-retina": "", /*iPad高分屏Spotlight搜索程序图标，分辨率：100x100*/
                        "spotlight-normal7": "",/*iPad iOS7 Spotlight搜索程序图标，分辨率：40x40*/
                        "spotlight-retina7": "",/*iPad iOS7高分屏Spotlight搜索程序图标，分辨率：80x80*/
                        "settings-normal": "",/*iPad设置页面程序图标，分辨率：29x29*/
                        "settings-retina": "" /*iPad高分屏设置页面程序图标，分辨率：58x58*/
                    }
                },
                "android": {
                    "mdpi": "", /*普通屏程序图标，分辨率：48x48*/
                    "ldpi": "", /*大屏程序图标，分辨率：48x48*/
                    "hdpi": "", /*高分屏程序图标，分辨率：72x72*/
                    "xhdpi": "",/*720P高分屏程序图标，分辨率：96x96*/
                    "xxhdpi": ""/*1080P 高分屏程序图标，分辨率：144x144*/
                }
            },
            "splashscreen": {
                "ios": {
                    "iphone": {
                        "default": "", /*iPhone3启动图片选，分辨率：320x480*/
                        "retina35": "",/*3.5英寸设备(iPhone4)启动图片，分辨率：640x960*/
                        "retina40": "",/*4.0 英寸设备(iPhone5/iPhone5s)启动图片，分辨率：640x1136*/
                        "retina47": "",/*4.7 英寸设备(iPhone6)启动图片，分辨率：750x1334*/
                        "retina55": "",/*5.5 英寸设备(iPhone6 Plus)启动图片，分辨率：1242x2208*/
                        "retina55l": ""/*5.5 英寸设备(iPhone6 Plus)横屏启动图片，分辨率：2208x1242*/
                    },
                    "ipad": {
                        "portrait": "", /*iPad竖屏启动图片，分辨率：768x1004*/
                        "portrait-retina": "",/*iPad高分屏竖屏图片，分辨率：1536x2008*/
                        "landscape": "", /*iPad横屏启动图片，分辨率：1024x748*/
                        "landscape-retina": "", /*iPad高分屏横屏启动图片，分辨率：2048x1496*/
                        "portrait7": "", /*iPad iOS7竖屏启动图片，分辨率：768x1024*/
                        "portrait-retina7": "",/*iPad iOS7高分屏竖屏图片，分辨率：1536x2048*/
                        "landscape7": "", /*iPad iOS7横屏启动图片，分辨率：1024x768*/
                        "landscape-retina7": ""/*iPad iOS7高分屏横屏启动图片，分辨率：2048x1536*/
                    }
                },
                "android": {
                    "mdpi": "", /*普通屏启动图片，分辨率：240x282*/
                    "ldpi": "", /*大屏启动图片，分辨率：320x442*/
                    "hdpi": "", /*高分屏启动图片，分辨率：480x762*/
                    "xhdpi": "", /*720P高分屏启动图片，分辨率：720x1242*/
                    "xxhdpi": ""/*1080P高分屏启动图片，分辨率：1080x1882*/
                }
            }
        }
    }
}