import { ActionTree } from 'vuex';
import { Vehicle, VehiclesState } from './state';
import { RootState } from '@/store/state';

export const types = {
  LOAD_VEHICLE: 'vehiclesStore/loadVehicles',
  ADD_VEHICLE: 'vehiclesStore/add',
  UPDATE_VEHICLE: 'vehiclesStore/update',
  REMOVE_VEHICLE: 'vehiclesStore/remove',
};

export const actions: ActionTree<VehiclesState, RootState> = {
  loadVehicles({ commit }): void {
      // TODO: Fetch the vehicle from the api
        const vehicles = [
          {VehicleId: 1, ModelName: 'Toyota Kia', RegNo: 'S20 UTT', Type: 1, IsAvailable: true},
          {VehicleId: 2, ModelName: 'Lamborgini', RegNo: 'L98 LTTT', Type: 1, IsAvailable: true},
        ];
        commit('setVehicles', vehicles);
    },

    add({commit}, vehicle: Vehicle): void {
      // TODO: make the api request before commiting to the store
      commit('add', vehicle);
    },

    update({commit}, vehicle: Vehicle): void {
      // TODO: make the api request before commiting to the store
      commit('update', vehicle);
    },

    remove({commit}, vehicleId: Vehicle): void {
      // TODO: make the api request before commiting to the store
      commit('remove', vehicleId);
    },
  };
