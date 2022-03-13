function initSvg(pIdentifier) {
    window.zoomTiger = svgPanZoom(pIdentifier, {
        zoomEnabled: true,
        controlIconsEnabled: true,
        fit: true,
        center: true,
        // viewportSelector: document.getElementById('demo-tiger').querySelector('#g4') // this option will make library to misbehave. Viewport should have no transform attribute
    });
}