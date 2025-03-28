import { ActionButton, Button } from "./button.model";

export interface Toolbar {
	mainButton: ActionButton;
	toolbarTitle: ToolbarTitle;
	secondaryButtons: Button[];
}

export type ToolbarTitle = {
	title: string;
	isMain: boolean;
};
