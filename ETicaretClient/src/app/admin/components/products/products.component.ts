import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/contracts/product';
import { HttpClientService } from 'src/app/services/common/http-client.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
})
export class ProductsComponent implements OnInit {
  constructor(private httpClientService: HttpClientService) {}

  ngOnInit(): void {
    this.httpClientService 
      .get<Product[]>({
        controller: 'products',
      })
      .subscribe((data) => {
        data[0].name;
        console.log(data);
      });
//test
    // this.httpClientService
    //   .post(
    //     { controller: 'products' },
    //     { name: 'Kalem12', stock: '12', price: '15' }
    //   )
    //   .subscribe();
    // this.httpClientService
    //   .put(
    //     { controller: 'products' },
    //     {
    //       id: '2351dfd5-458d-4ccc-b6ec-fd68dbc23de4',
    //       name: 'kamlem999',
    //       stock: 999,
    //       price: 32,
    //     }
    //   )
    //   .subscribe();
    // this.httpClientService
    //   .delete(
    //     { controller: 'products' },
    //     '2351dfd5-458d-4ccc-b6ec-fd68dbc23de4'
    //   )
    //   .subscribe();

    // this.httpClientService
    //   .get({
    //     baseUrl: 'https://jsonplaceholder.typicode.com',
    //     controller: 'posts',
    //   })
    //   .subscribe((data) => console.log(data));
    // this.httpClientService
    //   .get({
    //     fullEndPoint: 'https://jsonplaceholder.typicode.com/posts',
    //   })
    //   .subscribe((data) => console.log(data));
  }
}
