<template>
    <div v-if="IsAdding">
        <input v-model ="editAbleVehicle.ModelName" placeholder="Vehicle Model Name" >
            <button v-on:click="save()">Save</button>
            <button v-on:click="cancel()">Cancel</button>
    
    </div>
    <div v-else>
        <span>
            <button v-on:click="addVehicle()">Add</button>
        </span>
    </div>
</template>


<script lang="ts">

import { Prop, Vue, Component } from 'vue-property-decorator';
import { VehicleViewModel } from './model';

@Component({
    components: { },
})


export default class AddVehicle extends Vue {
    @Prop() private vehicle!: VehicleViewModel;
    private IsAdding: boolean = false;
    private editAbleVehicle: VehicleViewModel | null = null;

    private addVehicle() {
        this.editAbleVehicle = {VehicleId: 0, RegNo: '', ModelName: '', Type: 1, IsAvailable: true};
        this.IsAdding = true;
    }

    private save() {
        this.$emit('add', this.editAbleVehicle);
        this.IsAdding = false;
    }

    private cancel() {
        this.IsAdding = false;
        this.editAbleVehicle = null;
    }

}
</script>
