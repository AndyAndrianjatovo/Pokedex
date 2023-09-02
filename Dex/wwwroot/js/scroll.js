// wwwroot/js/scroll.js
function addScrollListener(dotnetObj) {
    window.addEventListener("scroll", function () {
        dotnetObj.invokeMethodAsync("OnScroll");
    });
}

function getWindowHeight() {
    return window.innerHeight || document.documentElement.clientHeight;
}

function getWindowScrollY() {
    return window.scrollY || window.pageYOffset || document.documentElement.scrollTop;
}

var GLOBAL = {};
GLOBAL.DotNetReference = null;
GLOBAL.SetDotnetReference = function (pDotNetReference) {
    GLOBAL.DotNetReference = pDotNetReference;
};

(function () {
    window.onscroll = function () {
        var windowHeight = window.innerHeight || document.documentElement.clientHeight;
        var scrollY = window.scrollY || window.pageYOffset || document.documentElement.scrollTop;

        var scrollMarker = document.getElementById("scroll-marker");
        if (scrollMarker) {
            var scrollMarkerOffsetTop = scrollMarker.offsetTop;

            if (scrollY + windowHeight >= scrollMarkerOffsetTop) {
                GLOBAL.DotNetReference.invokeMethodAsync('LoadMore');
            }
        }
    }

})();