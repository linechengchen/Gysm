/**
 * 去除所有的空格
 * @param {Object} content
 */
function spaceReplaceHollowString(content) {
	try {
		content = content.replace(/ /g, "");
	} catch (e) {
		throw e;
	}
	return content;
}

/*** @param {Object} datesStr */
function sprDay(datesStr) {
	datesStr = spaceReplaceHollowString(datesStr);
	var dataAllList = [];
	var dataAllListIndex = 0;
	var dateList = datesStr.split(",");
	dateList = dateList.sort();
	var year = null;
	for (var dIndex in dateList) {
		var dataStr = dateList[dIndex];
		var dateSplit = dataStr.split("-");
		if (dateSplit[0] != year) {
			dataAllList[dataAllListIndex] = {
				year: dateSplit[0]
			};
			year = dateSplit[0];
			var mouthAllList = new Array();
			var mouthAllListIndex = 0;
			var mouth = null;
			for (var yearIndex in dateList) {
				var yearDataStr = dateList[yearIndex];
				yearDataStr = yearDataStr.split("-");
				if (yearDataStr[0] == year) {
					if (mouth != yearDataStr[1]) {
						mouthAllList[mouthAllListIndex] = {
							mouth: yearDataStr[1]
						};
						mouth = yearDataStr[1];
						dataAllList[dataAllListIndex].mouth = mouthAllList;
						var dayAllList = new Array();
						var dayAllListIndex = 0;
						var day = null;
						var dayYear = 0;
						for (var dayIndex in dateList) {
							var dayDataStr = dateList[dayYear];
							dayYear++;
							dayDataStr = dayDataStr.split("-");
							if (dayDataStr[0] == year && dayDataStr[1] == mouth) {
								dayAllList[dayAllListIndex] = dayDataStr[2];
								dayAllListIndex++;
								day = dayDataStr[2];
							}
							dataAllList[dataAllListIndex].mouth[mouthAllListIndex].days = dayAllList;
						}
						mouthAllListIndex++;
					}
				}
			}
			dataAllListIndex++;
		}
	}
	return dataAllList;
}