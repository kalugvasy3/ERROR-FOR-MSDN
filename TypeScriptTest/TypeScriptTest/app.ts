
namespace AnotherPaart {

    let globe: Globe;

    window.onresize = () => {
        globe.engine.resize();
    }


     function start() {

        globe = new Globe('renderCanvas');
        globe.engine.runRenderLoop(() => globe.scene.render());

    };

};