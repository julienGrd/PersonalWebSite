function initSvg(pIdentifier) {
    window.zoomTiger = svgPanZoom(pIdentifier, {
        zoomEnabled: true,
        controlIconsEnabled: true,
        fit: true,
        center: true,
        // viewportSelector: document.getElementById('demo-tiger').querySelector('#g4') // this option will make library to misbehave. Viewport should have no transform attribute
    });
}

setTitle = (title) => { document.title = title; };

//let fileHandle;
//async function testFileSystem() {
//    //1 on enregistre un nouveau fichier
//   // fileHandle = await getNewFileHandle();

//    //2 on met a jour le contenu de ce fichier 
//   // writeFile(fileHandle, "https://localhost:5001/[15695] Cerfa-MDPH.pdf");

    

//    // Destructure the one-element array.
//    [fileHandle] = await window.showOpenFilePicker({
//        startIn: 'downloads',
//        suggestedName: 'mon fichier.pdf',
//        types: [
//            {
//                description: 'Fichiers PDF',
//                accept: {
//                    'application/pdf': ['.pdf'],
//                },
//            },
//        ],
//    });
//    // Do something with the file handle.
//}

//async function loadIframe() {
//    const file = await fileHandle.getFile();
//    var lUrl = objectURL = URL.createObjectURL(file);
//    document.getElementById("myiframe").src = lUrl;
//}

//async function retrieveFile() {
//    const file = await fileHandle.getFile();
//    var lUrl = objectURL = URL.createObjectURL(file);
//    window.open(lUrl);
//}

//async function getNewFileHandle() {
//    const options = {
//        suggestedName: 'mon fichier.pdf',
//        types: [
//            {
//                description: 'Fichiers PDF',
//                accept: {
//                    'application/pdf': ['.pdf'],
//                },
//            },
//        ],
//        startIn: 'downloads'
//    };
//    const handle = await window.showSaveFilePicker(options);
//    return handle;
//}

//async function writeFile(fileHandle, url) {
//    // Create a FileSystemWritableFileStream to write to.
//    const writable = await fileHandle.createWritable();
//    // Make an HTTP request for the contents.
//    const response = await fetch(url);
//    // Stream the response into the file.
//    await response.body.pipeTo(writable);
//    // Write the contents of the file to the stream.
//    //await writable.write(contents);
//    // Close the file and write the contents to disk.
//    await writable.close();
//}