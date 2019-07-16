import Vue from 'vue';
import Vuex, { StoreOptions, MutationTree, ActionTree } from 'vuex';
import { RootState} from './state';
import {vehiclesStore} from './modules/vehicles';

Vue.use(Vuex);

const options: StoreOptions<RootState> = {
    state: { },
    modules: {
      vehiclesStore,
    },
};

export default new Vuex.Store(options);


