import { Component, Input } from '@angular/core';
import { ButtonKind, ButtonType} from '@components/shared/button.model';
import {Action, createAction, Store} from '@ngrx/store';
import { ButtonComponent } from '@components/button/button.component';

@Component({
  selector: 'ig-action-button',
  templateUrl: './action-button.component.html',
  standalone: true,
  imports: [
    ButtonComponent
  ]
})
export class ActionButtonComponent {
  @Input()
  public label: string = "";

  @Input()
  public icon: string = "";

  @Input()
  public type: ButtonType = "button";

  @Input()
  public kind: ButtonKind = "default";

  @Input()
  public disabled: boolean = false;
  @Input()
  public action: Action = createAction('DummyAction');

  constructor(private store: Store) {}

  protected dispatch() {
    this.store.dispatch(this.action);
  }
}
