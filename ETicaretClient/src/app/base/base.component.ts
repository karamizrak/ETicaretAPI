import { NgxSpinnerService } from "ngx-spinner";

export class BaseComponent {

  constructor(private spinner: NgxSpinnerService) { }

  showSpinner(spinnerType: SpinnerType) {
    this.spinner.show(spinnerType);

    setTimeout(() => this.hideSpinner(spinnerType), 3000);
  }

  hideSpinner(spinnerType: SpinnerType) {
    this.spinner.hide(spinnerType);
  }


}

export enum SpinnerType {
  BallClipRotatePulse = "s1",
  Timer = "s2",
  BallAtom = "s3"
}