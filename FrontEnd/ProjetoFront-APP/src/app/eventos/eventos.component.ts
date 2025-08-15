import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  widthImage: number = 150;
  marginImg: number = 2;
  mostrarImg: boolean = true;
  private _filtroLista: string = '';
  eventosFiltrados: any;


  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value){
    this._filtroLista = value;
    this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos
  }


  filtrarEventos(filtrPor: string): any {
    filtrPor = filtrPor.toLowerCase();
    return this.eventos.filter(
      evento => evento.tema.toLowerCase().indexOf(filtrPor) !== -1 ||
      evento.local.toLowerCase().indexOf(filtrPor) !== -1
    )
  }


  constructor(private http : HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  alterarImg(){
    this.mostrarImg = !this.mostrarImg;
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
    response => {
      this.eventos = response;
      this.eventosFiltrados = this.eventos
    },
    error => {console.log(error)})
    ;
  }

}
