import {createFeatureSelector, createSelector} from '@ngrx/store';
import {SHELL_STATE_KEY, ShellState} from './shell.state';

const getShellState = createFeatureSelector<ShellState>(SHELL_STATE_KEY);

export const getOpened = createSelector(
  getShellState,
  state => state.opened
)
