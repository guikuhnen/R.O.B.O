import { Braco } from './braco';
import { Cabeca } from './cabeca';

export class Robo {
    cabeca: Cabeca;
    bracoDireito: Braco;
    bracoEsquerdo: Braco;

    constructor() {
        this.cabeca = new Cabeca();
        this.bracoDireito = new Braco();
        this.bracoEsquerdo = new Braco();
    }
}
