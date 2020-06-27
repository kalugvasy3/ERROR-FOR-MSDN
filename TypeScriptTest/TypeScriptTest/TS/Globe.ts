

namespace AnotherPaart {
    export class Globe {

        private _canvas: HTMLCanvasElement;

        private _resolution = 0.5;
        private _shiftAngle = 12.0;
        private _bordure = 20.0;

        public engine: BABYLON.Engine;

        public scene: BABYLON.Scene;
        public camera: BABYLON.Camera;

        private _radiuseOrbit: number;
        private _radiuseGlobe: number;

        private _vectorToTheSun: BABYLON.Vector3;





        public constructor(canvas: string = "") {
            this._canvas = document.getElementById(canvas) as HTMLCanvasElement;
            this.engine = new BABYLON.Engine(this._canvas, true);


            this._radiuseOrbit = 500.0;
            this._radiuseGlobe = 200.0;

            this.scene = this.createScene();
        }


        private createScene = () => {

            this.scene = new BABYLON.Scene(this.engine);
            this.camera = new BABYLON.ArcRotateCamera("Camera", Math.PI / 2, Math.PI / 2, this._radiuseOrbit, new BABYLON.Vector3(0, 0, 0), this.scene);
            this.camera.attachControl(this._canvas, true);

            //let light = new BABYLON.HemisphericLight("ambient", new BABYLON.Vector3(1, 1, 0), this.scene);
            


            let light = new BABYLON.HemisphericLight("light1", new BABYLON.Vector3(0, 1, 0), this.scene);
            light.intensity = 0.7;
            light.diffuse = BABYLON.Color3.White();
          
            let sphere = BABYLON.MeshBuilder.CreateSphere("sphere", { diameter: this._radiuseGlobe }, this.scene);
            

            let mat = new BABYLON.StandardMaterial("Earth", this.scene);
            mat.ambientTexture = new BABYLON.Texture("world.png", this.scene);  //_simlify
            sphere.material = mat;

            

            return this.scene;

        }

    }
}




