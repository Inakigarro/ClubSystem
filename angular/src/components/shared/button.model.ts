export interface Button {
	label: string;
	icon: string;
	type: ButtonType;
	kind: ButtonKind;
}

export type ButtonType = "button" | "submit" | "reset";
export type ButtonKind = "default" | "flat" | "raised" | "icon";
