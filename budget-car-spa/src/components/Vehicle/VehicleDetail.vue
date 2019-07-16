<template>
    <div v-if="IsEditable">
        <input v-model ="editAbleVehicle.ModelName" placeholder="Vehicle Model Name" >
            <button v-on:click="update()">Update</button>
            <button v-on:click="cancel()">Cancel</button>
            <button v-on:click="remove()">Delete</button>
    
    </div>
    <div v-else>
        <span>
            {{ vehicle.ModelName }} 
            <button v-on:click="edit()">Edit</button>
        </span>
    </div>
</template>


<script lang="ts">

import { Prop, Vue, Component } from 'vue-property-decorator';
import { VehicleViewModel } from './model';

@Component({
    components: { },
})


export default class VehicleDetail extends Vue {
    @Prop() private vehicle!: VehicleViewModel;
    private IsEditable: boolean = false;
    private editAbleVehicle: VehicleViewModel | null = null;

    private edit() {
        this.IsEditable = true;
        this.editAbleVehicle = {...this.vehicle};
    }

    private update() {
        // console.log(this.editAbleVehicle);
        this.$emit('update', this.editAbleVehicle);
        this.IsEditable = false;

    }

    private cancel() {
        this.IsEditable = false;
        this.editAbleVehicle = null;
    }

    private remove() {
        // console.log(this.editAbleVehicle.VehicleId);
        this.$emit('remove', this.editAbleVehicle!.VehicleId);
    }

}
</script>
