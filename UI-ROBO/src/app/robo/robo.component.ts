import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

import { Robo } from 'src/app/models/robo';
import { RoboService } from 'src/app/services/robo.service';
import { membrosRobo } from 'src/app/models/enum-robo-estados.enum';

@Component({
  selector: 'app-robo',
  templateUrl: './robo.component.html',
  styleUrls: ['./robo.component.css']
})
export class RoboComponent implements OnInit {

  estadosRobo: Robo;

  public get membrosRobo(): typeof membrosRobo {
    return membrosRobo;
  }

  constructor(private roboService: RoboService) { }

  ngOnInit(): void {
    this.getEstadosRobo();
  }

  getEstadosRobo() {
    this.estadosRobo = new Robo();
    this.roboService.getEstadosRobo().subscribe((robo: Robo) => this.estadosRobo = robo);
  }

  setEstadoRobo(membro: membrosRobo, acao: membrosRobo, executar: number) {
    switch (executar) {
      case 1: // Adicionar
        this.aumentarEstadoRobo(membro, acao);
        break;

      case 2: // Subtrair
        this.diminuirEstadoRobo(membro, acao);
        break;

      default:
        break;
    }

    this.roboService.setEstadosRobo(this.estadosRobo).subscribe(response => this.getEstadosRobo());
  }

  aumentarEstadoRobo(membro: membrosRobo, acao: membrosRobo) {
    switch (membro) {
      case membrosRobo.Cabeca:

        if (acao == membrosRobo.CabecaRotacao) {
          this.estadosRobo.cabeca.rotacao = this.estadosRobo.cabeca.rotacao + 1;
        } else {
          this.estadosRobo.cabeca.inclinacao = this.estadosRobo.cabeca.inclinacao + 1;
        }

        break;

      case membrosRobo.BracoDireito:

        if (acao == membrosRobo.BracoDireitoCotovelo) {
          this.estadosRobo.bracoDireito.cotovelo = this.estadosRobo.bracoDireito.cotovelo + 1;
        } else {
          this.estadosRobo.bracoDireito.pulso = this.estadosRobo.bracoDireito.pulso + 1;
        }

        break;

      case membrosRobo.BracoEsquerdo:

        if (acao == membrosRobo.BracoEsquerdoCotovelo) {
          this.estadosRobo.bracoEsquerdo.cotovelo = this.estadosRobo.bracoEsquerdo.cotovelo + 1;
        } else {
          this.estadosRobo.bracoEsquerdo.pulso = this.estadosRobo.bracoEsquerdo.pulso + 1;
        }

        break;

      default:
        break;
    }
  }

  diminuirEstadoRobo(membro: membrosRobo, acao: membrosRobo) {
    switch (membro) {
      case membrosRobo.Cabeca:

        if (acao == membrosRobo.CabecaRotacao) {
          this.estadosRobo.cabeca.rotacao = this.estadosRobo.cabeca.rotacao - 1;
        } else {
          this.estadosRobo.cabeca.inclinacao = this.estadosRobo.cabeca.inclinacao - 1;
        }

        break;

      case membrosRobo.BracoDireito:

        if (acao == membrosRobo.BracoDireitoCotovelo) {
          this.estadosRobo.bracoDireito.cotovelo = this.estadosRobo.bracoDireito.cotovelo - 1;
        } else {
          this.estadosRobo.bracoDireito.pulso = this.estadosRobo.bracoDireito.pulso - 1;
        }

        break;

      case membrosRobo.BracoEsquerdo:

        if (acao == membrosRobo.BracoEsquerdoCotovelo) {
          this.estadosRobo.bracoEsquerdo.cotovelo = this.estadosRobo.bracoEsquerdo.cotovelo - 1;
        } else {
          this.estadosRobo.bracoEsquerdo.pulso = this.estadosRobo.bracoEsquerdo.pulso - 1;
        }

        break;

      default:
        break;
    }
  }
}