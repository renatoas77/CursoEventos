import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Eventos',
  templateUrl: './Eventos.component.html',
  styleUrls: ['./Eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any =[
    {
      Tema: 'Angular 11',
      Local: 'Belo Horizonte'
    },
    {
      Tema: '.NET 6.0',
      Local: 'São Paulo'
    },
    {
      Tema: 'Angular e suas novidades',
      Local: 'Rio de Janeiro'
    }

  ]

  constructor() { }

  ngOnInit(): void {
  }

}
