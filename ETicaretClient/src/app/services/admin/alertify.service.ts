import { Injectable } from '@angular/core';
declare var alertify: any;
@Injectable({
  providedIn: 'root',
})
export class AlertifyService {
  constructor() {}
  message(msjObj: Partial<AlertifyOptions>) {
    alertify.set('notifier', 'delay', msjObj.delay);
    alertify.set('notifier', 'position', msjObj.position);
    const msg = alertify[msjObj.messageType](msjObj.message);
    if (msjObj.dismissOthers) msg.dismissOthers();
  }
  dismiss() {
    alertify.dismissAll();
  }
}

export enum MessageType {
  Error = 'error',
  Message = 'message',
  Notify = 'notify',
  Success = 'success',
  Warning = 'warning',
}

export enum Position {
  BottomRight = 'bottom-right',
  BottomLeft = 'bottom-left',
  BottomCenter = 'bottom-center',
  TopCenter = 'top-center',
  TopRight = 'top-right',
  TopLeft = 'top-left',
}
export class AlertifyOptions {
  message: string;
  messageType: MessageType = MessageType.Message;
  position: Position = Position.BottomLeft;
  delay: number = 3;
  dismissOthers: boolean = false;
}
