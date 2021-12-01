import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { VendaService } from 'src/app/services/venda.service';

@Component({
  selector: 'app-create-venda',
  templateUrl: './create-venda.component.html',
  styleUrls: ['./create-venda.component.css']
})
export class CreateVendaComponent implements OnInit {

  constructor(private router: Router, private vendaService: VendaService) { }

  ngOnInit(): void {
  }

}
