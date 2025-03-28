import { Component } from "@angular/core";
import { Toolbar } from "@components/shared/toolbar.model";
import { Button } from "@components/shared/button.model";
import { ShellComponent } from "../shell/shell.component";
import { RouterOutlet } from "@angular/router";
import {menuButtonClicked} from '@app/app.actions';

@Component({
	selector: "app-root",
	imports: [ShellComponent, RouterOutlet],
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
      action: menuButtonClicked,
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
