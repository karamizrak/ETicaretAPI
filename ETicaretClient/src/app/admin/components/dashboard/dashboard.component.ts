import { Component, OnInit } from '@angular/core';
import {
  AlertifyOptions,
  AlertifyService,
  MessageType,
  Position,
} from 'src/app/services/admin/alertify.service';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss'],
})
export class DashboardComponent implements OnInit {
  constructor(private alertify: AlertifyService) {}

  ngOnInit(): void {}

  m() {
    sss: AlertifyOptions;

    this.alertify.message({
      messageType: MessageType.Success,
      delay: 5,
      position: Position.TopCenter,
      dismissOthers: false,
      message: 'Merhaba Angular. Nasılsın?',
    });
  }
  dismiss() {
    this.alertify.dismiss();
  }
}
