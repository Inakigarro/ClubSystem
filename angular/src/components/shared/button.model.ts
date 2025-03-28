import {Action} from '@ngrx/store';

export type ButtonType = "button" | "submit" | "reset";
export type ButtonKind = "default" | "flat" | "raised" | "icon";

export interface Button {
	label: string;
	icon: string;
	type: ButtonType;
	kind: ButtonKind;
}

export interface ActionButton extends Button {
  action: Action;
}
