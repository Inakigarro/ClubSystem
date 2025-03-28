import {createReducer, on} from '@ngrx/store';
import {menuButtonClicked} from '@app/app.actions';
export const SHELL_STATE_KEY = 'shell';
export interface ShellState {
  opened: boolean;
}

export const InitialState: ShellState = {
  opened: false,
}

export const shellReducer = createReducer(
  InitialState,
  on(menuButtonClicked, (state) => ({
    ...state,
    opened: !state.opened
  })))
