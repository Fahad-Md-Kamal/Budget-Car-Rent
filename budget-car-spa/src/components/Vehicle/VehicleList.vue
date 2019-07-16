<template>
<ul>
    <li v-for="vehicle in VehicleList" v-bind:key="vehicle.VehicleId">
        <VehicleDetail v-bind:vehicle="vehicle" v-on:update= "onUpdate" v-on:remove= "onRemove"/>
    </li>
    <li>
        <AddVehicle v-on:add= "onAdd" />
    </li>
</ul>
</template>


<script lang="ts">

import { Prop, Component, Vue } from 'vue-property-decorator';
import { VehicleViewModel } from './model';
import VehicleDetail from './VehicleDetail.vue';
import AddVehicle from './AddVehicle.vue';

@Component({
    components: {
        VehicleDetail,
        AddVehicle,
    },
})




export default class VehicleList extends Vue {
    @Prop() private VehicleList!: VehicleViewModel[];

    private onUpdate(vehicle: VehicleViewModel) {
        this.$emit('update', vehicle);
    }

    private onRemove(VehicleId: number) {
        this.$emit('remove', VehicleId);
    }

    private onAdd(vehicle: VehicleViewModel) {
       this.$emit('add', vehicle);
   }
}


</script>


<style lang="scss">
ul{
    list-style: none;
}
</style>
