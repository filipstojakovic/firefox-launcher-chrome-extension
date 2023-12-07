chrome.runtime.onInstalled.addListener(function () {
	chrome.contextMenus.create({
		id: 'openWithFirefox',
		title: 'Open with Firefox',
		contexts: ['all'],
	});
});

chrome.contextMenus.onClicked.addListener(function (info, tab) {
	if (info.menuItemId === 'openWithFirefox') {
		// Get the video URL
		const videoUrl = info.linkUrl || info.pageUrl;

		// Perform some action (e.g., open a new tab with the video URL)
		if (!tab.incognito) chrome.tabs.create({ url: 'ff://' + videoUrl });
		else chrome.tabs.create({ url: 'ff://' + videoUrl + '--private' });
	}
});
