import { Button } from "./button.model";

export interface Toolbar {
	mainButton: Button;
	toolbarTitle: ToolbarTitle;
	secondaryButtons: Button[];
}

export type ToolbarTitle = {
	title: string;
	isMain: boolean;
};
