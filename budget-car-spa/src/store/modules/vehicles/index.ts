import { Module } from 'vuex';
import { VehiclesState } from './state';
import { RootState } from '@/store/state';
import {actions} from './actions';
import {mutations} from './mutations';

export const vehiclesStore: Module<VehiclesState, RootState> = {
    namespaced: true,
    actions,
    mutations,
    state: {
        vehicles: [ ],
    },
};
