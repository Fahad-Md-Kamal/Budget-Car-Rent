<template>

  <VehicleList v-bind:VehicleList= "vehicles" v-on:update= "onUpdate" v-on:remove= "onRemove" v-on:add="onAdd"/>

</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import VehicleList from '../components/Vehicle/VehicleList.vue';
import {VehicleViewModel} from '../components/Vehicle/model';

@Component({
  components: {
    VehicleList,
  },
})

export default class Vehicle extends Vue {
  private cId: number = 0;
  private vehicles: VehicleViewModel[] = [
    {VehicleId: ++this.cId, ModelName: 'Toyota', RegNo: 'S20 UTT', Type: 1, IsAvailable: true},
    {VehicleId: ++this.cId, ModelName: 'Lamborgini', RegNo: 'L98 LTTT', Type: 1, IsAvailable: true},
  ];

  private onUpdate(vehicle: VehicleViewModel) {
    const index = this.vehicles.findIndex( (v) => v.VehicleId === vehicle.VehicleId );
    this.vehicles = [...this.vehicles.slice( 0, index), vehicle,
      ...this.vehicles.slice(index + 1, this.vehicles.length)];
  }

  private onRemove(vehicleid: number) {
    this.vehicles = this.vehicles.filter( (v) => v.VehicleId !== vehicleid );
  }

  private onAdd(vehicle: VehicleViewModel) {
    vehicle.VehicleId = ++this.cId;
    this.vehicles = [...this.vehicles, vehicle];
  }



}
</script>
