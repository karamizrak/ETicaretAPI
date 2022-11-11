import { Injectable } from '@angular/core';
import { Create_Product } from 'src/app/contracts/create_product';
import { HttpClientService } from '../http-client.service';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private httpClientService: HttpClientService) { }
  create(product:Create_Product) {
    this.httpClientService.post<Create_Product>({
      controller: "products",

    }, product).subscribe(result => {
      alert("basarılı");
    });
  }
}
