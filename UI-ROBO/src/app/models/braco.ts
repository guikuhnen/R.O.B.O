import { posicaoCotovelo, rotacaoPulso } from './enum-robo-estados.enum';

export class Braco {
    cotovelo: posicaoCotovelo;
    cotoveloDesc: string;
    pulso: rotacaoPulso;
    pulsoDesc: string;
}
