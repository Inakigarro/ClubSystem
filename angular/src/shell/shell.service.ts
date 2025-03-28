import {Injectable} from '@angular/core';
import {Store} from '@ngrx/store';
import { getOpened } from './state/shell.selectors';

@Injectable({
  providedIn: 'root',
})
export class ShellService {
  public sidenavOpened$ = this.store.select(getOpened);

  constructor(private store: Store) { }
}
