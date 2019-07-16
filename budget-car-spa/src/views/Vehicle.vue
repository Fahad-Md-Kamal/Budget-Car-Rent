<template>

  <VehicleList v-bind:VehicleList= "vehicles" v-on:update= "onUpdate" v-on:remove= "onRemove" v-on:add="onAdd"/>

</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import VehicleList from '../components/Vehicle/VehicleList.vue';
import {VehicleViewModel} from '../components/Vehicle/model';
import { types } from '../store/modules/vehicles/actions';
import {State, namespace }  from 'vuex-class';

const vehicleModule = namespace('vehiclesStore');

@Component({
  components: {
    VehicleList,
  },
})

export default class Vehicle extends Vue {
  // It resolves the argument and stores the result in vehicles array.
  @vehicleModule.State('vehicles') private vehicles!: VehicleViewModel[];
  @vehicleModule.Action('loadVehicles') private loadVehicles!: () => void;




  // private get vehicles(): VehicleViewModel[] {
  //   return this.$store.state.vehiclesStore.vehicles;
  // }

  private mounted(): void {
    //this.$store.dispatch(types.LOAD_VEHICLE); // another way of doing same
    this.loadVehicles();
  }


  private onUpdate(vehicle: VehicleViewModel) {
    this.$store.dispatch(types.UPDATE_VEHICLE, vehicle);
  }

  private onRemove(vehicleid: number) {
    this.$store.dispatch(types.REMOVE_VEHICLE, vehicleid);
  }

  private onAdd(vehicle: VehicleViewModel) {
    this.$store.dispatch(types.ADD_VEHICLE, vehicle);
  }



}
</script>
