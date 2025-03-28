import { Component, Input } from "@angular/core";
import { MatToolbarModule } from "@angular/material/toolbar";
import {ActionButton, Button} from "@components/shared/button.model";
import { ButtonComponent } from "@components/button/button.component";
import { ToolbarTitle } from "@components/shared/toolbar.model";
import {ActionButtonComponent} from '@components/action-button/action-button.component';

@Component({
	selector: "ig-toolbar",
	templateUrl: "./toolbar.component.html",
	styleUrl: "./toolbar.component.scss",
	standalone: true,
  imports: [MatToolbarModule, ButtonComponent, ActionButtonComponent],
})
export class ToolbarComponent {
	@Input()
	public mainButton: ActionButton | undefined;

	@Input()
	public title: ToolbarTitle | undefined;

	@Input()
	public secondaryButtons: Button[] = [];
}
