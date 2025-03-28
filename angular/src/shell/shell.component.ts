import { Component, Input } from "@angular/core";
import { ToolbarComponent } from "@components/toolbar/toolbar.component";
import { DrawerComponent } from "@components/drawer/drawer.component";
import { Toolbar } from "@components/shared/toolbar.model";
import { Button } from "@components/shared/button.model";
import { ButtonComponent } from "@components/button/button.component";
import {ShellService} from './shell.service';
import {Observable} from 'rxjs';
import {AsyncPipe} from '@angular/common';

@Component({
	selector: "ig-shell",
	templateUrl: "shell.component.html",
	standalone: true,
  imports: [DrawerComponent, ToolbarComponent, ButtonComponent, AsyncPipe],
})
export class ShellComponent {
	@Input()
	public toolbar: Toolbar | undefined;

	@Input()
	public sidenavButtons: Button[] = [];

  protected opened: Observable<boolean> = this.service.sidenavOpened$;

  constructor(private service: ShellService) {}
}
