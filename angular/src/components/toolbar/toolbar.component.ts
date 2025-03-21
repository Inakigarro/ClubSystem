import { Component, Input } from "@angular/core";
import { MatToolbarModule } from "@angular/material/toolbar";
import { Button } from "@components/shared/button.model";
import { ButtonComponent } from "@components/button/button.component";
import { ToolbarTitle } from "@components/shared/toolbar.model";

@Component({
	selector: "ig-toolbar",
	templateUrl: "./toolbar.component.html",
	styleUrl: "./toolbar.component.scss",
	standalone: true,
	imports: [MatToolbarModule, ButtonComponent],
})
export class ToolbarComponent {
	@Input()
	public mainButton: Button | undefined;

	@Input()
	public title: ToolbarTitle | undefined;

	@Input()
	public secondaryButtons: Button[] = [];
}
