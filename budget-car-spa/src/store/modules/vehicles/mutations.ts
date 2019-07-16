import { MutationTree } from 'vuex';
import { VehiclesState, Vehicle } from './state';

let cid: number = 2;

export const mutations: MutationTree<VehiclesState> = {

    setVehicles(state: VehiclesState, vehicles: Vehicle[] ): void {
        state.vehicles = [...vehicles];
    },

    add(state: VehiclesState, vehicle: Vehicle): void {
        vehicle.VehicleId = ++cid;
        state.vehicles = [...state.vehicles, vehicle];
    },

    update(state: VehiclesState, vehicle: Vehicle ): void {
        const index = state.vehicles.findIndex( (v) => v.VehicleId === vehicle.VehicleId );
        state.vehicles = [...state.vehicles.slice( 0, index),
            vehicle, ...state.vehicles.slice(index + 1, state.vehicles.length)];
    },

    remove(state: VehiclesState, vehicleid: number) {
        state.vehicles = state.vehicles.filter( (v) => v.VehicleId !== vehicleid );
    },
};
