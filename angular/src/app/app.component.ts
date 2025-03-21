import { Component } from "@angular/core";
import { Toolbar } from "@components/shared/toolbar.model";
import { ToolbarComponent } from "@components/toolbar/toolbar.component";

@Component({
	selector: "app-root",
	imports: [ToolbarComponent],
	templateUrl: "./app.component.html",
	styleUrl: "./app.component.scss",
})
export class AppComponent {
	protected toolbar: Toolbar = {
		mainButton: {
			icon: "menu",
			label: "",
			type: "button",
			kind: "icon",
		},
		toolbarTitle: {
			isMain: true,
			title: "Club System",
		},
		secondaryButtons: [
			{
				icon: "account_circle",
				label: "",
				type: "button",
				kind: "icon",
			},
		],
	};
}
