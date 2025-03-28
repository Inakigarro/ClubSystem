import { Component, EventEmitter, Input, Output } from "@angular/core";
import { ButtonKind, ButtonType } from "../shared/button.model";
import { MatButtonModule } from "@angular/material/button";
import { MatIconModule } from "@angular/material/icon";

@Component({
	selector: "ig-button",
	templateUrl: "./button.component.html",
	styleUrl: "./button.component.scss",
	standalone: true,
	imports: [MatButtonModule, MatIconModule],
})
export class ButtonComponent {
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

  @Output()
  public onClick: EventEmitter<any> = new EventEmitter();
}
