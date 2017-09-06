// 
//  booklist.js
//  book
//  
//  Created by 成新 朱 on 2017-02-11.
//  Copyright 2017 成新 朱. All rights reserved.
// 
'use strict'
var fetchBanner,
	fetchBookList,
	fetchBookDetail,
	fetchSearchResult;
//var siteUrlJson = 'http://stbd.aibangxs.com/site_shuati/json_shuati/';
(function($, doc) {
	fetchBanner = function(callback) {

		$.ajax(siteUrlJson + 'b_indexBanners.aspx', {
			dataType: 'json',
			type: 'get', //HTTP请求类型
			timeout: 15000, //超时时间设置为10秒；
			headers: {
				'Content-Type': 'application/json'
			},
			success: function(data) {
				console.log(data);
				callback && callback(data)
			},
		});
	}

	// 请求书本列表
	fetchBookList = function(callback) {
		$.ajax(siteUrlJson + 'b_indexRecommends.aspx', {
			dataType: 'json',
			type: 'get', //HTTP请求类型
			timeout: 15000, //超时时间设置为10秒；
			headers: {
				'Content-Type': 'application/json'
			},
			success: function(data) {
				console.log(data);
				callback && callback(data)
			},
		});
	}

}(mui, document));