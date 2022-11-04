import { Component } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { MessageType } from './services/admin/alertify.service';
import {
  CustomToastrService,
  ToasterMessageType,
} from './services/ui/custom-toastr.service';
declare var $: any;

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'ETicaretClient';
  /**
   *
   */
  /**
   *
   */
  constructor() {}
  // constructor(private toastrService: CustomToastrService) {
  //   toastrService.message('Merhaba1', 'Başlık', {
  //     messageType: ToasterMessageType.Info,
  //   });
  //   toastrService.message('Merhaba2', 'Başlık', {
  //     messageType: ToasterMessageType.Success,
  //   });
  //   toastrService.message('Merhaba3', 'Başlık', {
  //     messageType: ToasterMessageType.Warning,
  //   });
  //   toastrService.message('Merhaba4', 'Başlık', {
  //     messageType: ToasterMessageType.Error,
  //   });
  // }
}

// $(document).ready(() => {
//   alert('sdads');
// });
