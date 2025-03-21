import { Component } from "@angular/core";
import { Toolbar } from "@components/shared/toolbar.model";
import { ToolbarComponent } from "@components/toolbar/toolbar.component";
import { DrawerComponent } from "@components/drawer/drawer.component";
import { Button } from "@components/shared/button.model";
import { ButtonComponent } from "@components/button/button.component";
import {ShellComponent} from '../shell/shell.component';

@Component({
	selector: "app-root",
	imports: [ShellComponent],
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

	protected sidenavButtons: Button[] = [
		{
			label: "Members",
			icon: "",
			type: "button",
			kind: "raised",
		},
	];
}
