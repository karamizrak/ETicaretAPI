import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root',
})
export class CustomToastrService {
  constructor(private toastr: ToastrService) {}

  message(
    message: string,
    title: string,
    toasterOptions: Partial<ToasterOptions>
  ) {
    this.toastr[toasterOptions.messageType](
      message,
      toasterOptions.messageType
    );
  }
}

export enum ToasterMessageType {
  Success = 'success',
  Info = 'info',
  Warning = 'warning',
  Error = 'error',
}

export enum ToasterPositionType {
  TopRight = 'toast-top-right',
  BottomRight = 'toast-bottom-right',
  BottomLeft = 'toast-bottom-left',
  TopLeft = 'toast-top-left',
  TopFullWidth = 'top-full-width',
  BottomFullWidth = 'bottom-full-width',
  TopCenter = 'toast-top-center',
  BottomCenter = 'toast-bottom-center',
}

export class ToasterOptions {
  messageType: ToasterMessageType;
  position: ToasterPositionType;
}
