export enum membrosRobo {
    Cabeca,
    CabecaRotacao,
    CabecaInclinacao,
    BracoEsquerdo,
    BracoEsquerdoCotovelo,
    BracoEsquerdoPulso,
    BracoDireito,
    BracoDireitoCotovelo,
    BracoDireitoPulso
}

// Cabeca

export enum rotacaoCabeca {
    Menos90Graus = 1,
    Menos45Graus = 2,
    EmRepouso = 3,
    Mais45Graus = 4,
    Mais90Graus = 5
}

export enum inclinacaoCabeca {
    ParaCima = 1,
    EmRepouso = 2,
    ParaBaixo = 3
}

// Cabeca //

// Bracos

export enum posicaoCotovelo {
    EmRepouso = 1,
    LevementeContraido = 2,
    Contraido = 3,
    FortementeContraido = 4
}

export enum rotacaoPulso {
    Menos90Graus = 1,
    Menos45Graus = 2,
    EmRepouso = 3,
    Mais45Graus = 4,
    Mais90Graus = 5,
    Mais135Graus = 6,
    Mais180Graus = 7
}

// Bracos //